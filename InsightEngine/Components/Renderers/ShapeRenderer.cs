using InsightEngine.Contract;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace InsightEngine.Components.Renderers
{
    public abstract class ShapeRenderer : Component, ISavable
    {
        /// <summary>
        /// Nazwa obiektu. Do rozpoznawania przy zapisie i odczycie.
        /// </summary>
        public abstract string Tag { get; }
        /// <summary>
        /// Obiekt siatki 3D.
        /// </summary>
        protected Mesh mesh;
        /// <summary>
        /// Liczba punktów tworzących obiekt 3D.
        /// </summary>
        protected abstract int numberVerts { get; }
        /// <summary>
        /// Lista określająca w jaki sposób punkty mają być ze sobą połączone.
        /// </summary>
        protected List<short> indices = new List<short>();

        public float Scale = 0.3f;

        protected Random rand = new Random();


        public override void Start()
        {
            base.Start();
            SetIndices(this.indices);
            GenerateMesh(GeneratePoints);
        }

        public override void Update()
        {
            base.Update();
            DrawMesh();
        }

        /// <summary>
        /// Procedura rysująca gotową siatkę 3D.
        /// </summary>
        protected void DrawMesh()
        {
            mesh.DrawSubset(0);
        }

        /// <summary>
        /// Procedura tworząca siatkę 3D.
        /// </summary>
        /// <param name="genetarePoints"></param>
        protected void GenerateMesh(Action<GraphicsStream> genetarePoints)
        {
            mesh = new Mesh(numberVerts * 3, numberVerts, MeshFlags.Managed,
                CustomVertex.PositionColored.Format, device);

            using (VertexBuffer vb = mesh.VertexBuffer)
            {
                GraphicsStream data = vb.Lock(0, 0, LockFlags.None);

                genetarePoints?.Invoke(data);

                vb.Unlock();
            }

            using (IndexBuffer ib = mesh.IndexBuffer)
            {
                ib.SetData(indices.ToArray(), 0, LockFlags.None);
            }
        }

        /// <summary>
        /// Procedura ustawiająca punkty danego obiektu.
        /// </summary>
        /// <param name="data"></param>
        protected abstract void GeneratePoints(GraphicsStream data);

        /// <summary>
        /// Procedura ustawiająca które punkty mają zostać ze sobą połączone.
        /// </summary>
        /// <param name="indices"></param>
        protected abstract void SetIndices(List<short> indices);

        protected void LoadMesh(string filename, ref Mesh mesh, ref Material[] meshmaterials, ref Texture[] meshtextures, ref float meshradius)
        {
            ExtendedMaterial[] materialarray;
            mesh = Mesh.FromFile(filename, MeshFlags.Managed, device, out materialarray);

            if ((materialarray != null) && (materialarray.Length > 0))
            {
                meshmaterials = new Material[materialarray.Length];
                meshtextures = new Texture[materialarray.Length];

                for (int i = 0; i < materialarray.Length; i++)
                {
                    meshmaterials[i] = materialarray[i].Material3D;
                    meshmaterials[i].Ambient = meshmaterials[i].Diffuse;

                    if ((materialarray[i].TextureFilename != null) && (materialarray[i].TextureFilename != string.Empty))
                    {
                        meshtextures[i] = TextureLoader.FromFile(device, materialarray[i].TextureFilename);
                    }
                }
            }

            mesh = mesh.Clone(mesh.Options.Value, CustomVertex.PositionNormalTextured.Format, device);
            mesh.ComputeNormals();

            float scaling = 0.0005f;

            VertexBuffer vertices = mesh.VertexBuffer;
            GraphicsStream stream = vertices.Lock(0, 0, LockFlags.None);
            Vector3 meshcenter;
            meshradius = Geometry.ComputeBoundingSphere(stream, mesh.NumberVertices, mesh.VertexFormat, out meshcenter) * scaling;
            vertices.Unlock();
        }

        protected int RandomizeColor(Color color)
        {
            try
            {
                var variation = rand.Next(-30, 30);
                return Color.FromArgb(color.R + variation,
                    color.G + variation, color.B + variation).ToArgb();
            }
            catch (Exception)
            {
                return color.ToArgb();
            }
        }

        protected void SetPoint(GraphicsStream data, Vector3 point, int color)
        {
            data.Write(new CustomVertex.PositionColored(point, color));
        }

        protected Vector3 GetPointWithTransformAndScale(float x, float y, float z)
        {
            return new Vector3(0, 0, 0) * Scale + Transform.Position;
        }

        protected void SetColoredPoint(float x, float y, float z,
            Color colorBase, GraphicsStream data)
        {
            var point = new Vector3(x, y, z) * Scale + Transform.Position;
            var color = RandomizeColor(colorBase);
            SetPoint(data, point, color);
        }

        public string ToSavable()
        {
            var pos = Transform.Position;

            var result = $"{{{pos.X}:{pos.Y}:{pos.Z}:{Tag}}};";

            return result;
        }
    }
}
