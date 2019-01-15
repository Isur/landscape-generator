using InsightEngine;
using InsightEngine.Components;
using InsightEngine.Input;
using InsightEngine.Model.Color;
using PerlinNoise;
using PerlinNoise.Config;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace TerrainGenerator
{
    public partial class Form1 : Form
    {
        Scene mainScene;

        private void initializeScene()
        {
            mainScene = new Scene(this);

            var regions = createRegions();
            var terrain = createTerrain(regions);
            var camera = createCamera();

            mainScene.AddEntity(terrain);
            mainScene.AddEntity(camera);

            mainScene.Start();
        }

        public Form1(string[] args)
        {
            try
            {
                this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.Opaque, true); //this needs to be set so the invalidate() function in the paint event works properly
                InitializeComponent();

                handleApplicationArguments(args);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void handleApplicationArguments(string[] args)
        {
            if (args.Length == 1)
            {
                mainScene = new Scene(this);
                var camera = createCamera();
                mainScene.AddEntity(camera);
                var savePath = args[0];
                mainScene.Load(savePath);
                mainScene.Start();
            }
            else if (args.Length == 4)
            {
                Settings.MapSize = int.Parse(args[0]);
                Settings.ModelsChance = getModelChance(args[1]);
                PerlinParameters.power = float.Parse(args[2]);
                PerlinParameters.Scales[4] = 0.5f + float.Parse(args[3]) / 10;

                initializeScene();
            }
            else
            {
                initializeScene();
            }
        }

        float getModelChance(string chance)
        {
            switch (chance)
            {
                case "0": return 0.00003f;
                case "1": return 0.0001f;
                case "2": return 0.0003f;
                default: return 0;
            }
        }

        List<ColorRegion> createRegions()
        {
            var regions = new List<ColorRegion>()
            {
                new ColorRegion(Color.FromArgb(240, 240, 240), 0.5), // Biały na szczyty gór
                new ColorRegion(Color.FromArgb(180, 170, 170), 0.8), // Szary na wzniesienia
                new ColorRegion(Color.FromArgb(175, 120, 50), 0.4), // Brązowy na ziemie
                new ColorRegion(Color.FromArgb(50, 180, 50), 0.1), // Ciemno-zielony na wyżyny
            };

            for (int i = 10; i > 1; i--)
            {
                regions.Add(new ColorRegion(Color.FromArgb(60 - i, 200 - 2 * i, 60 - i), 0.1));//Zielone
            }

            regions.Add(new ColorRegion(Color.FromArgb(60, 200, 60), 0.1));  // Zielony na doliny
            regions.Add(new ColorRegion(Color.FromArgb(230, 235, 80), 0.1)); //Zółty na piasek
            regions.Add(new ColorRegion(Color.FromArgb(55, 120, 230), 0.3)); // Niebieski na wodę 

            return regions;
        }

        Entity createCamera()
        {
            var cameraController = new CameraController();
            cameraController.MoveSpeed = 20;

            var camera = new Entity();
            camera.Transform.Position =
                new Microsoft.DirectX.Vector3(Settings.MapSize / 2, 2775, -1000);
            camera.AddComponent(cameraController);

            return camera;
        }

        Entity createTerrain(List<ColorRegion> regions)
        {
            var terrainGenerator = new InsightEngine.Components.TerrainGenerator();
            terrainGenerator.Regions.AddRange(regions);
            terrainGenerator.NoiseGenerator = new SimplePerlinNoise(Settings.MapSize, 2);

            var terrain = new Entity();
            terrain.AddComponent(terrainGenerator);

            return terrain;
        }

        private void Form1_Paint(object sender, PaintEventArgs e) //here is the drawing loop
        {
            mainScene.Update();
            this.Invalidate();
            Thread.Sleep(10);
        }

        //Przekazanie inputu do silnika.
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Keyboard.W = e.KeyCode == Keys.W;
            Keyboard.S = e.KeyCode == Keys.S;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Mouse.X = e.X;
            Mouse.Y = e.Y;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Mouse.Click = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Mouse.Click = false;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var saveDialog = new SaveFileDialog();

            saveDialog.Filter = "ton files (*.ton)|*.ton";
            saveDialog.FilterIndex = 2;
            saveDialog.RestoreDirectory = true;
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                var filename = saveDialog.FileName;
                mainScene.Save(filename);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}