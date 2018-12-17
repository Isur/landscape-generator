using InsightEngine.Contract;
using InsightEngine.Model.Color;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using PerlinNoise;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace InsightEngine.Components
{
    public class TerrainGenerator : Component
    {
        public float Devider { get; set; } = 99f;
        public float Multiplier { get; set; } = 1000f;

        public int Width { get; set; } = 2000;
        public int Lenght { get; set; } = 2000;
        public bool UseColors { get; set; } = true;

        int vertCount { get; set; }
        int indCount { get; set; }

        CustomVertex.PositionColored[] verts { get; set; } = null;
        int[] indices { get; set; } = null;

        VertexBuffer vertexBuffer { get; set; } = null;
        IndexBuffer indexBuffer { get; set; } = null;

        public float[,] PerlinVerts { get; private set; }

        private ColorManager colorManager { get; set; }


        public override void Start()
        {
            vertCount = Width * Lenght;
            indCount = (Width - 1) * (Lenght - 1) * 6;

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
            var perlin = new SimplePerlinNoise(Width, 2);
            int k = 0;

            PerlinVerts = new float[Width, Lenght];
            var min = 0f;
            var max = 0f;

            var rand = new Random();
            // gererating array of heights, highest point and lowest point
            for (int z = 0; z < Width; z++)
            {
                for (int x = 0; x < Lenght; x++)
                {
                    var y = perlin.CalculatePerlinOctaves(x, z, Width);
                    PerlinVerts[x, z] = y;

                    if (y < min) min = y;
                    if (y > max) max = y;
                }
            }

            var regions = new List<ColorRegion>()
            {
                new ColorRegion(Color.FromArgb(240, 240, 240), 1), // Biały na szczyty gór
                new ColorRegion(Color.FromArgb(180, 170, 170), 1), // Szary na wzniesienia
                new ColorRegion(Color.FromArgb(175, 120, 50), 0.4), // Brązowy na ziemie
                new ColorRegion(Color.FromArgb(60, 200, 60), 1.6), // Zielony na doliny
                new ColorRegion(Color.FromArgb(230, 235, 80), 0.2), //Zółty na piasek
                new ColorRegion(Color.FromArgb(55, 120, 230), 1) // Niebieski na wodę 
            };

            colorManager = new ColorManager((int)min, (int)max, regions);

            // initialize vertexes
            for (int z = 0; z < Width; z++)
            {
                for (int x = 0; x < Lenght; x++)
                {
                    var y = PerlinVerts[x, z];
                    verts[k].Position = new Vector3(x, y, z);

                    int color = Color.Blue.ToArgb();
                    if (UseColors)
                    {
                        if (y > 0)
                            color = colorManager.GetColor(verts[k].Position);//Color.FromArgb(255, (int)map(y, 0, max, 255, 0), 0).ToArgb();
                        else
                            color = colorManager.GetColor(verts[k].Position);//Color.FromArgb((int)map(y, min, 0, 0, 255), 255, 0).ToArgb();
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
                indices[i + 1] = k + Lenght;     // left triangle of the square
                indices[i + 2] = k + Lenght + 1; //

                indices[i + 3] = k;                   //
                indices[i + 4] = k + Lenght + 1;   // right triangle of the square
                indices[i + 5] = k + 1;               //
                k++;
                l++;
                if (l == Lenght - 1) //once one line of rectangles is created and the end of the line is beeing reached skip one k
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

        public static TerrainGenerator operator +(TerrainGenerator first, TerrainGenerator second)
        {
            if (first.Lenght != second.Lenght ||
                first.Width != second.Width)
                throw new Exception();

            var verts = new float[first.Width, first.Lenght];

            for (int i = 0; i < first.Width; i++)
            {
                for (int j = 0; j < first.Lenght; j++)
                {
                    if (first.PerlinVerts[j, i] > second.PerlinVerts[j, i])
                        verts[j, i] = first.PerlinVerts[j, i];
                    else
                        verts[j, i] = second.PerlinVerts[j, i];
                }
            }

            return null;
        }
    }
}
