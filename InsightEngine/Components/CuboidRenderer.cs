using InsightEngine.Contract;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;

namespace InsightEngine.Components
{
    public class CuboidRenderer : Component
    {
        public float Width { get; set; } = 20;
        public float Height { get; set; } = 20;
        public float Depth { get; set; } = 20;

        int numberVerts = 8;
        short[] indices = {
            0,1,2, // Front Face 
            1,3,2, // Front Face 
            4,5,6, // Back Face 
            6,5,7, // Back Face 
            0,5,4, // Top Face 
            0,2,5, // Top Face 
            1,6,7, // Bottom Face 
            1,7,3, // Bottom Face 
            0,6,1, // Left Face 
            4,6,0, // Left Face 
            2,3,7, // Right Face 
            5,2,7 // Right Face 
        };

        public override void Start()
        {

        }

        public override void Update()
        {
            //Transform.Position = new Vector3(
            //    Transform.Position.X + 1,
            //    Transform.Position.Y,
            //    Transform.Position.Z
            //    );
            //var box = Mesh.Box(device, 100f, 100f, 100f);

            //for (var i = 0; i < box.NumberVertices; i++)
            //    box.DrawSubset(i);

            Mesh mesh = new Mesh(numberVerts * 3, numberVerts, MeshFlags.Managed,
                     CustomVertex.PositionColored.Format, device);

            using (VertexBuffer vb = mesh.VertexBuffer)
            {
                GraphicsStream data = vb.Lock(0, 0, LockFlags.None);

                var halfWidth = Width / 2;
                var halfHeight = Height / 2;
                var halfDepth = Depth / 2;

                data.Write(new CustomVertex.PositionColored(-halfWidth + Transform.Position.X, halfHeight + Transform.Position.Y, halfDepth + Transform.Position.Z, 0x00ff00ff));
                data.Write(new CustomVertex.PositionColored(-halfWidth + Transform.Position.X, -halfHeight + Transform.Position.Y, halfDepth + Transform.Position.Z, 0x00ff00ff));
                data.Write(new CustomVertex.PositionColored(halfWidth + Transform.Position.X, halfHeight + Transform.Position.Y, halfDepth + Transform.Position.Z, 0x00ff00ff));
                data.Write(new CustomVertex.PositionColored(halfWidth + Transform.Position.X, -halfHeight + Transform.Position.Y, halfDepth + Transform.Position.Z, 0x00ff00ff));
                data.Write(new CustomVertex.PositionColored(-halfWidth + Transform.Position.X, halfHeight + Transform.Position.Y, -halfDepth + Transform.Position.Z, 0x00ff00ff));
                data.Write(new CustomVertex.PositionColored(halfWidth + Transform.Position.X, halfHeight + Transform.Position.Y, -halfDepth + Transform.Position.Z, 0x00ff00ff));
                data.Write(new CustomVertex.PositionColored(-halfWidth + Transform.Position.X, -halfHeight + Transform.Position.Y, -halfDepth + Transform.Position.Z, 0x00ff00ff));
                data.Write(new CustomVertex.PositionColored(halfWidth + Transform.Position.X, -halfHeight + Transform.Position.Y, -halfDepth + Transform.Position.Z, 0x00ff00ff));

                vb.Unlock();
            }

            using (IndexBuffer ib = mesh.IndexBuffer)
            {
                ib.SetData(indices, 0, LockFlags.None);
            }

            for (var i = 0; i < mesh.NumberVertices; i++)
                mesh.DrawSubset(i);
        }
    }
}
