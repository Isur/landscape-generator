using Microsoft.DirectX;
using System.Collections.Generic;
using System.Drawing;

namespace InsightEngine.Components.Renderers
{
    public class SimpleBushRenderer : ShapeRenderer
    {
        public override string Tag { get { return "Bush"; } }

        protected override int numberVerts { get { return 12; } }

        protected override void GeneratePoints(GraphicsStream data)
        {
            var colorBase = Color.FromArgb(20, 130, 20);
            var color = RandomizeColor(colorBase);

            var point = new Vector3(0, 0, 0) * Scale + Transform.Position;
            color = RandomizeColor(colorBase);
            SetPoint(data, point, color);

            point = new Vector3(10, 0, 0) * Scale + Transform.Position;
            color = RandomizeColor(colorBase);
            SetPoint(data, point, color);

            point = new Vector3(0, 0, 10) * Scale + Transform.Position;
            color = RandomizeColor(colorBase);
            SetPoint(data, point, color);

            point = new Vector3(10, 0, 10) * Scale + Transform.Position;
            color = RandomizeColor(colorBase);
            SetPoint(data, point, color);

            point = new Vector3(0, 10, 0) * Scale + Transform.Position;
            color = RandomizeColor(colorBase);
            SetPoint(data, point, color);

            point = new Vector3(10, 10, 0) * Scale + Transform.Position;
            color = RandomizeColor(colorBase);
            SetPoint(data, point, color);

            point = new Vector3(0, 10, 10) * Scale + Transform.Position;
            color = RandomizeColor(colorBase);
            SetPoint(data, point, color);

            point = new Vector3(10, 10, 10) * Scale + Transform.Position;
            color = RandomizeColor(colorBase);
            SetPoint(data, point, color);

            point = new Vector3(20, 20, 5) * Scale + Transform.Position;
            color = RandomizeColor(colorBase);
            SetPoint(data, point, color);

            point = new Vector3(-10, 20, 5) * Scale + Transform.Position;
            color = RandomizeColor(colorBase);
            SetPoint(data, point, color);

            point = new Vector3(5, 20, 20) * Scale + Transform.Position;
            color = RandomizeColor(colorBase);
            SetPoint(data, point, color);

            point = new Vector3(5, 20, -10) * Scale + Transform.Position;
            color = RandomizeColor(colorBase);
            SetPoint(data, point, color);
        }

        protected override void SetIndices(List<short> indices)
        {
            indices.AddRange(new short[]
            {
                1,0,4,
                4,5,1, //front
                3,1,5,
                5,7,3, //right
                2,0,4,
                4,6,2, //left
                2,6,7,
                7,3,2, //back
                6,7,5,
                5,4,6, //top
                6,9,4,
                4,9,0,
                0,9,2,
                2,9,6, //left spike
                5,8,7,
                7,8,3,
                3,8,1,
                1,8,5, //right spike
                7,10,3,
                3,10,2,
                2,10,6,
                6,10,7, //back spike
                4,11,5,
                5,11,1,
                1,11,0,
                0,11,4 //front spike
            });
        }
    }
}
