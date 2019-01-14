using InsightEngine.Components;
using InsightEngine.Components.Renderers;
using InsightEngine.Input;
using InsightEngine.Model.Load;
using Microsoft.DirectX.Direct3D;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace InsightEngine
{
    public class Scene
    {
        List<Entity> entities { get; }
        List<Entity> entitiesToAdd { get; }
        public Device Device { get; set; }

        public Scene(Control control)
        {
            entities = new List<Entity>();
            entitiesToAdd = new List<Entity>();

            SetupDevice(control);
        }

        public void AddEntity(Entity entity)
        {
            entities.Add(entity);
            entity.Scene = this;
        }

        public void Start()
        {
            foreach (var entity in entities)
            {
                entity.Start();
            }

            Device.RenderState.Lighting = false;
            Device.RenderState.CullMode = Cull.None; //sets which site of the triangles should be shown
            Device.RenderState.FillMode = FillMode.Solid; //this sets the mode so we can actually see the triangle construct of the terrain
        }

        private void SetupDevice(Control control)
        {
            PresentParameters pp = new PresentParameters();
            pp.Windowed = true;
            pp.SwapEffect = SwapEffect.Discard; //just how the stuff should be moved from the backbuffer to the front buffer
            pp.EnableAutoDepthStencil = true;
            pp.AutoDepthStencilFormat = DepthFormat.D16;

            Device = new Device(0, DeviceType.Hardware, control, CreateFlags.HardwareVertexProcessing, pp);
        }

        public void Update()
        {
            var skyColor = Color.FromArgb(135, 206, 235);
            Device.Clear(ClearFlags.Target | ClearFlags.ZBuffer, skyColor, 1, 0);
            Device.BeginScene();
            Device.VertexFormat = CustomVertex.PositionColored.Format;

            foreach (var entity in entities)
            {
                entity.Update();
            }

            if (entitiesToAdd.Count > 0)
            {
                entities.AddRange(entitiesToAdd);
                entitiesToAdd.Clear();
            }

            Device.EndScene();
            Device.Present();

            Keyboard.Reset();
            Mouse.Reset();
        }

        public void Instantiate(Entity entity)
        {
            entitiesToAdd.Add(entity);
            entity.Scene = this;
            entity.Start();
        }

        public void Save(string file)
        {
            var toSave = GetContentToSave();
            SaveContent(file, toSave);
        }

        private string GetContentToSave()
        {
            var terrainSavable = "";
            var modelsSavable = new StringBuilder();
            modelsSavable.Append("[");

            foreach (var entity in entities)
            {
                var terrain = entity.GetComponent<TerrainGenerator>();
                if (terrain != null)
                    terrainSavable += terrain.ToSavable();

                var model = entity.GetComponent<ShapeRenderer>();
                if (model != null)
                    modelsSavable.Append(model.ToSavable());
            }

            modelsSavable.Append("]");

            var toSave = terrainSavable +
                Environment.NewLine +
                modelsSavable.ToString();

            return toSave;
        }

        private void SaveContent(string file, string content)
        {
            using (var writer = new StreamWriter(file))
            {
                writer.WriteLine(content);
            }
        }

        public void Load(string file)
        {
            var terrainLine = "";
            var modelsLine = "";

            using (var reader = new StreamReader(file))
            {
                terrainLine = reader.ReadLine();
                modelsLine = reader.ReadLine();
            }

            modelsLine = modelsLine.Substring(1, modelsLine.Length - 3);
            terrainLine = terrainLine.Substring(1, terrainLine.Length - 3);

            var modelsSplitted = modelsLine.Split(';');
            var terrainSplitted = terrainLine.Split(';');

            var loadedVerts = new CustomVertex.PositionColored[terrainSplitted.Length];
            Settings.MapSize = (int)Math.Sqrt(terrainSplitted.Length);

            for (var i = 0; i < terrainSplitted.Length; i++)
            {
                var loadTerranVertex = new LoadTerrainVertex(terrainSplitted[i]);
                loadedVerts[i] = loadTerranVertex.ToColoredVertex();
            }

            var terrain = new Entity();
            var terrainRenderer = new TerrainGenerator();
            terrainRenderer.verts = loadedVerts;
            terrain.AddComponent(terrainRenderer);
            AddEntity(terrain);

            for (var i = 0; i < modelsSplitted.Length - 1; i++)
            {
                var loadModel = new LoadModel(modelsSplitted[i]);

                var entity = new Entity();
                var transform = new Transform(loadModel.Position);
                var renderer = GetRenderer(loadModel);
                entity.Transform = transform;
                entity.AddComponent(renderer);

                AddEntity(entity);
            }
        }

        private ShapeRenderer GetRenderer(LoadModel model)
        {
            if (model.Tag == "Rock")
                return new SimpleRockRenderer();
            if (model.Tag == "Palm")
                return new SimplePalmRenderer();
            if (model.Tag == "Bush")
                return new SimpleBushRenderer();

            return null;
        }
    }
}
