using InsightEngine.Contract;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using PerlinNoise;
using System;
using System.Drawing;

namespace InsightEngine.Components
{
    public class TerrainGenerator : Component
    {

        public int Depth = 200; //depth
        public float scale1 = 4.3f;
        public float scale2 = 2.5f;
        public float scale3 = 50f;
        public float scale1weight = 1f;
        public float scale2weight = 0.5f;
        public float scale3weight = 0.01f;
        public float power = 5f;
        public float offsetX = 100f;
        public float offsetZ = 100f;

        public float Devider { get; set; } = 7f;
        public float Multiplier { get; set; } = 20f;

        public int Width { get; set; } = 1000;
        public int Lenght { get; set; } = 1000;
        public bool UseColors { get; set; } = true;

        int vertCount { get; set; }
        int indCount { get; set; }

        CustomVertex.PositionColored[] verts { get; set; } = null;
        int[] indices { get; set; } = null;

        VertexBuffer vertexBuffer { get; set; } = null;
        IndexBuffer indexBuffer { get; set; } = null;


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

            var perlinVerts = new float[Width, Lenght];
            var min = 0f;
            var max = 0f;

            var rand = new Random();
            // gererating array of heights, highest point and lowest point
            for (int z = 0; z < Width; z++)
            {
                for (int x = 0; x < Lenght; x++)
                {
                    // var y = perlin.CalculatePerlin(x / Devider, z / Devider);
                    float y = scale1weight * perlin.CalculatePerlin((float)x / Width * scale1, (float)z / Width * scale1) + scale2weight * perlin.CalculatePerlin((float)x / Width * scale2, (float)z / Width * scale2) + scale3weight * perlin.CalculatePerlin((float)x / Width * scale3, (float)z / Width * scale3);

                    y += 0.5f;
                    y *= 5;
                    y = (float)Math.Pow(y, 5);

                    //if (y > 0)
                    // //   y *= rand.Next(1, 60);
                    //else
                    // //   y *= rand.Next(1, 3);

                    perlinVerts[x, z] = y;

                    if (y < min) min = y;
                    if (y > max) max = y;
                }
            }

            // initialize vertexes
            for (int z = 0; z < Width; z++)
            {
                for (int x = 0; x < Lenght; x++)
                {
                    var y = perlinVerts[x, z];
                    float heightColor = y / max * 255;
                    verts[k].Position = new Vector3(x, y, z);

                    int color = Color.Blue.ToArgb();
                    if (UseColors)
                    {
                        if (y > (max/10))
                            color = Color.FromArgb(255, (int)map(y, 0, max, 255, 0), 0).ToArgb();
                        else
                            color = Color.FromArgb((int)heightColor, 255, 0).ToArgb();
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
    }
}
