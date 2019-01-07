using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using System.Collections.Generic;

namespace InsightEngine.Components.Renderers
{
    public class CuboidRenderer : ShapeRenderer
    {
        public float Width { get; set; } = 20;
        public float Height { get; set; } = 20;
        public float Depth { get; set; } = 20;

        protected override int numberVerts { get { return 8; } }

        public override string Tag { get { return "Cuboid"; } }

        protected override void GeneratePoints(GraphicsStream data)
        {
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
        }

        protected override void SetIndices(List<short> indices)
        {
            indices.AddRange(new short[] {
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
            });
        }
    }
}
