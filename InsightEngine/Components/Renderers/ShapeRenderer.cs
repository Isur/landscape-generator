using InsightEngine.Contract;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using System;
using System.Collections.Generic;

namespace InsightEngine.Components.Renderers
{
    public abstract class ShapeRenderer : Component
    {
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
            for (var i = 0; i < mesh.NumberVertices; i++)
                mesh.DrawSubset(i);
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
    }
}
