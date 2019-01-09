using InsightEngine.Components.Renderers;
using InsightEngine.Contract;
using InsightEngine.Enum;
using InsightEngine.Model.Color;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using PerlinNoise.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace InsightEngine.Components
{
    public class TerrainGenerator : Component, ISavable
    {
        public float Devider { get; set; } = 99f;
        public float Multiplier { get; set; } = 1000f;
        public bool UseColors { get; set; } = true;
        public bool Use3dModels { get; set; } = false;
        public float ModelGenerationChance { get; set; } = 0.0001f;

        public List<ColorRegion> Regions { get; } = new List<ColorRegion>();

        int vertCount { get; set; }
        int indCount { get; set; }

        CustomVertex.PositionColored[] verts { get; set; } = null;
        int[] indices { get; set; } = null;

        VertexBuffer vertexBuffer { get; set; } = null;
        IndexBuffer indexBuffer { get; set; } = null;

        public float[,] PerlinVerts { get; private set; }

        private ColorManager colorManager { get; set; }

        public INoiseGenerator NoiseGenerator { get; set; }

        Random rand = new Random();

        public override void Start()
        {
            vertCount = Properties.Settings.Default.LandscapeSize * Properties.Settings.Default.LandscapeSize;
            indCount = (Properties.Settings.Default.LandscapeSize - 1) * (Properties.Settings.Default.LandscapeSize - 1) * 6;

            GenerateTerrain();

            CreateEvents();
        }

        public override void Update()
        {
            device.SetStreamSource(0, vertexBuffer, 0); //tells the device where to receive the vertex information from
            device.Indices = indexBuffer; //tells the device where to receive the index information from
            device.DrawIndexedPrimitives(PrimitiveType.TriangleList, 0, 0, vertCount, 0, indCount / 3); //draws the triangles depending on the style we set it using the information from indices
        }

        private void GenerateTerrain()
        {
            GenerateVertex();
            GenerateIndex();

            vertexBuffer = new VertexBuffer(typeof(CustomVertex.PositionColored), vertCount, device, Usage.Dynamic | Usage.WriteOnly, CustomVertex.PositionColored.Format, Pool.Default);
            OnVertexBufferCreate(vertexBuffer, null);

            indexBuffer = new IndexBuffer(typeof(int), indCount, device, Usage.WriteOnly, Pool.Default);
            OnIndexBufferCreate(indexBuffer, null);
        }

        private void CreateEvents()
        {
            vertexBuffer.Created += new EventHandler(OnVertexBufferCreate);
            indexBuffer.Created += new EventHandler(OnIndexBufferCreate);
        }

        private void GenerateVertex()
        {
            verts = new CustomVertex.PositionColored[vertCount];
            int k = 0;

            PerlinVerts = new float[Properties.Settings.Default.LandscapeSize, Properties.Settings.Default.LandscapeSize];
            var min = 0f;
            var max = 0f;

            // gererating array of heights, highest point and lowest point
            for (int z = 0; z < Properties.Settings.Default.LandscapeSize; z++)
            {
                for (int x = 0; x < Properties.Settings.Default.LandscapeSize; x++)
                {
                    var y = NoiseGenerator.CalculateNoiseValue(x, z, Properties.Settings.Default.LandscapeSize);
                    PerlinVerts[x, z] = y;

                    if (y < min) min = y;
                    if (y > max) max = y;
                }
            }

            colorManager = new ColorManager((int)min, (int)max, Regions);

            // initialize vertexes
            for (int z = 0; z < Properties.Settings.Default.LandscapeSize; z++)
            {
                for (int x = 0; x < Properties.Settings.Default.LandscapeSize; x++)
                {
                    var y = PerlinVerts[x, z];
                    verts[k].Position = new Vector3(x, y, z);

                    int color = Color.Blue.ToArgb();
                    if (UseColors)
                    {
                        var result = colorManager.GetColor(verts[k].Position);
                        color = result.Key;

                        if (CanGenerate3dModel(result.Value))
                        {
                            Generate3dModel(verts[k].Position);
                        }
                    }
                    else
                    {
                        color = Color.FromArgb(0, 0, (int)map(y, min, max, 185, 255)).ToArgb();
                    }

                    verts[k].Color = color;
                    k++;
                }
            }
        }

        bool CanGenerate3dModel(ColorRegion region)
        {
            var chance = rand.Next(0, (int)(ModelGenerationChance / ModelGenerationChance / ModelGenerationChance));
            var regionId = Regions.IndexOf(region);
            return Use3dModels && chance == 0 && regionId >= 3 && regionId < 15;
        }

        void Generate3dModel(Vector3 position)
        {
            var plantVariations = System.Enum.GetNames(typeof(ObjectType)).Length;
            var plantType = (ObjectType)rand.Next(0, plantVariations);
            InstantiatePlant(position, plantType);
        }

        void InstantiatePlant(Vector3 position, ObjectType type)
        {
            var transformm = new Transform(position);
            var plant = new Entity();
            plant.Transform = transformm;

            ShapeRenderer renderer = null;

            if (type == ObjectType.BUSH)
                renderer = new SimpleBushRenderer();
            else if (type == ObjectType.PALM)
                renderer = new SimplePalmRenderer();
            else if (type == ObjectType.ROCK)
                renderer = new SimpleRockRenderer();

            renderer.Scale = 0.3f;
            plant.AddComponent(renderer);
            Instantiate(plant);
        }

        float map(float s, float a1, float a2, float b1, float b2)
        {
            return b1 + (s - a1) * (b2 - b1) / (a2 - a1);
        }

        private void GenerateIndex() // Generating all the indices vor the Index buffer (Her we tell how to connect the vertices to creat triangles)
        {
            indices = new int[indCount];

            int k = 0;
            int l = 0;
            for (int i = 0; i < indCount; i += 6)
            {
                indices[i] = k;                     //
                indices[i + 1] = k + Properties.Settings.Default.LandscapeSize;     // left triangle of the square
                indices[i + 2] = k + Properties.Settings.Default.LandscapeSize + 1; //

                indices[i + 3] = k;                   //
                indices[i + 4] = k + Properties.Settings.Default.LandscapeSize + 1;   // right triangle of the square
                indices[i + 5] = k + 1;               //
                k++;
                l++;
                if (l == Properties.Settings.Default.LandscapeSize - 1) //once one line of rectangles is created and the end of the line is beeing reached skip one k
                {
                    l = 0;
                    k++;
                }
            }
        }

        private void OnIndexBufferCreate(object sender, EventArgs e)
        {
            IndexBuffer buffer = (IndexBuffer)sender;
            buffer.SetData(indices, 0, LockFlags.None); //puts all indices from the int array into the index buffer
        }

        private void OnVertexBufferCreate(object sender, EventArgs e)
        {
            VertexBuffer buffer = (VertexBuffer)sender;
            buffer.SetData(verts, 0, LockFlags.None); //puts all vertices from the vertex array into the vertex buffer
        }

        public string ToSavable()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("[");

            foreach (var vert in verts)
            {
                builder.Append($"{{{vert.X}:{vert.Y}:{vert.Z}:{vert.Color}}},");
            }

            builder.Append("]");

            return builder.ToString();
        }
    }
}
