using Microsoft.DirectX;
using System.Collections.Generic;
using System.Drawing;

namespace InsightEngine.Components.Renderers
{
    public class SimplePalmRenderer : ShapeRenderer
    {
        public override string Tag { get { return "Palm"; } }
        public int Height { get; set; } = 150;
        public int BaseWidth { get; set; } = 10;

        protected override int numberVerts { get { return 17; } }

        protected override void GeneratePoints(GraphicsStream data)
        {
            var baseColor = Color.FromArgb(133, 94, 66);
            var color = RandomizeColor(baseColor);

            SetColoredPoint(0, 0, 0, baseColor, data);
            SetColoredPoint(BaseWidth, 0, 0, baseColor, data);
            SetColoredPoint(BaseWidth, 0, BaseWidth, baseColor, data);
            SetColoredPoint(0, 0, BaseWidth, baseColor, data);
            SetColoredPoint(BaseWidth / 2, Height, BaseWidth / 2, baseColor, data);

            baseColor = Color.FromArgb(20, 130, 20);
            SetColoredPoint((BaseWidth / 2) - BaseWidth * 2, Height + BaseWidth, (BaseWidth / 2) + BaseWidth, baseColor, data);
            SetColoredPoint((BaseWidth / 2) - BaseWidth * 2, Height + BaseWidth, (BaseWidth / 2) - BaseWidth, baseColor, data);
            SetColoredPoint((BaseWidth / 2) - BaseWidth, Height * 3 / 4, BaseWidth / 2, baseColor, data); // left leaf

            SetColoredPoint((BaseWidth / 2) + BaseWidth * 2, Height + BaseWidth, (BaseWidth / 2) + BaseWidth, baseColor, data);
            SetColoredPoint((BaseWidth / 2) + BaseWidth * 2, Height + BaseWidth, (BaseWidth / 2) - BaseWidth, baseColor, data);
            SetColoredPoint((BaseWidth / 2) + BaseWidth, Height * 3 / 4, BaseWidth / 2, baseColor, data); // right leaf

            SetColoredPoint((BaseWidth / 2) + BaseWidth, Height + BaseWidth, (BaseWidth / 2) + BaseWidth * 2, baseColor, data);
            SetColoredPoint((BaseWidth / 2) - BaseWidth, Height + BaseWidth, (BaseWidth / 2) + BaseWidth * 2, baseColor, data);
            SetColoredPoint((BaseWidth / 2), Height * 3 / 4, (BaseWidth / 2) + BaseWidth, baseColor, data); // back leaf

            SetColoredPoint((BaseWidth / 2) + BaseWidth, Height + BaseWidth, (BaseWidth / 2) - BaseWidth * 2, baseColor, data);
            SetColoredPoint((BaseWidth / 2) - BaseWidth, Height + BaseWidth, (BaseWidth / 2) - BaseWidth * 2, baseColor, data);
            SetColoredPoint((BaseWidth / 2), Height * 3 / 4, (BaseWidth / 2) - BaseWidth, baseColor, data); // front leaf
        }

        protected override void SetIndices(List<short> indices)
        {
            indices.AddRange(new short[]
            {
                0,4,1,
                1,4,2,
                2,4,3,
                3,4,0, // trunk

                4,5,6,
                5,6,7, // left

                4,8,9,
                8,9,10, // right

                4,11,12,
                11,12,13, // back

                4,14,15,
                14,15,16 // front
            });
        }
    }
}
