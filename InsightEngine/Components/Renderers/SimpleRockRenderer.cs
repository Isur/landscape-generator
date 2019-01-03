using Microsoft.DirectX;
using System.Collections.Generic;
using System.Drawing;

namespace InsightEngine.Components.Renderers
{
    public class SimpleRockRenderer : ShapeRenderer
    {
        public int Width { get; set; } = 30;
        public int Height { get; set; } = 20;
        public int Length { get; set; } = 30;

        protected override int numberVerts { get { return 10; } }

        protected override void GeneratePoints(GraphicsStream data)
        {
            var baseColor = Color.FromArgb(128, 128, 128);
            var color = RandomizeColor(baseColor);

            SetColoredPoint(0, 0, Length / 2, baseColor, data);
            SetColoredPoint(-Width / 2, 0, Width / 2, baseColor, data);
            SetColoredPoint(-Width / 2, 0, -Width / 2, baseColor, data);
            SetColoredPoint(0, 0, -Length / 2, baseColor, data);
            SetColoredPoint(Width / 2, 0, -Width / 2, baseColor, data);
            SetColoredPoint(Width / 2, 0, Width / 2, baseColor, data);

            SetColoredPoint(-Width / 4, Height, Width / 2, baseColor, data);
            SetColoredPoint(-Width / 4, Height, -Width / 2, baseColor, data);
            SetColoredPoint(Width / 4, Height, -Width / 2, baseColor, data);
            SetColoredPoint(Width / 4, Height, Width / 2, baseColor, data);
        }

        protected override void SetIndices(List<short> indices)
        {
            indices.AddRange(new short[]
            {
                0,1,6,
                0,6,9,
                0,9,5,
                5,9,4,
                9,4,8,
                4,8,3,
                3,8,7,
                3,7,2,
                2,7,1,
                1,7,6,
                6,9,7,
                7,9,8,
                0,1,5,
                1,5,2,
                5,2,4,
                2,4,3
            });
        }
    }
}
