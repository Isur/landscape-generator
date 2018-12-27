using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using System.Collections.Generic;

namespace InsightEngine.Components.Renderers
{
    public class SimpleBushRenderer : ShapeRenderer
    {
        public float Scale = 0.3f;

        protected override int numberVerts { get { return 12; } }

        protected override void GeneratePoints(GraphicsStream data)
        {
            var color = 0x0000ff00;

            var point = new Vector3(0, 0, 0) * Scale;
            SetPoint(data, point, color);

            point = new Vector3(10, 0, 0) * Scale;
            SetPoint(data, point, color);

            point = new Vector3(0, 0, 10) * Scale;
            SetPoint(data, point, color);

            point = new Vector3(10, 0, 10) * Scale;
            SetPoint(data, point, color);

            point = new Vector3(0, 10, 0) * Scale;
            SetPoint(data, point, color);

            point = new Vector3(10, 10, 0) * Scale;
            SetPoint(data, point, color);

            point = new Vector3(0, 10, 10) * Scale;
            SetPoint(data, point, color);

            point = new Vector3(10, 10, 10) * Scale;
            SetPoint(data, point, color);

            point = new Vector3(20, 20, 5) * Scale;
            SetPoint(data, point, color);

            point = new Vector3(-10, 20, 5) * Scale;
            SetPoint(data, point, color);

            point = new Vector3(5, 20, 20) * Scale;
            SetPoint(data, point, color);

            point = new Vector3(5, 20, -10) * Scale;
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
