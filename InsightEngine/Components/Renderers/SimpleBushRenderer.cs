using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using System.Collections.Generic;

namespace InsightEngine.Components.Renderers
{
    public class SimpleBushRenderer : ShapeRenderer
    {
        protected override int numberVerts { get { return 6; } }

        protected override void GeneratePoints(GraphicsStream data)
        {
            var color = 0x0000ff00;

            var point = new Vector3(0, 0, 0);
            SetPoint(data, point, color);

            point = new Vector3(10, 0, 0);
            SetPoint(data, point, color);

            point = new Vector3(0, 0, 10);
            SetPoint(data, point, color);

            point = new Vector3(10, 0, 10);
            SetPoint(data, point, color);

            point = new Vector3(0, 10, 0);
            SetPoint(data, point, color);

            point = new Vector3(10, 10, 0);
            SetPoint(data, point, color);

            point = new Vector3(0, 10, 10);
            SetPoint(data, point, color);

            point = new Vector3(10, 10, 10);
            SetPoint(data, point, color);
            //
            point = new Vector3(20, 20, 5);
            SetPoint(data, point, color);

            point = new Vector3(-10, 20, 5);
            SetPoint(data, point, color);

            point = new Vector3(5, 20, 20);
            SetPoint(data, point, color);

            point = new Vector3(5, 20, -10);
            SetPoint(data, point, color);
        }

        void SetPoint(GraphicsStream data, Vector3 point, int color)
        {
            data.Write(new CustomVertex.PositionColored(point, color));
        }

        protected override void SetIndices(List<short> indices)
        {
            indices.AddRange(new short[]
            {
                1,8,3,
                1,3,5,
                5,8,7,
                3,8,7,

                3,10,2,
                3,10,7,
                7,10,6,
                6,10,2,

                6,9,4,
                6,9,2,
                4,9,0,
                0,9,2,

                4,11,5
            });
        }
    }
}
