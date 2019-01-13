using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;

namespace InsightEngine.Model.Load
{
    public class LoadTerrainVertex
    {
        public float X { get; private set; }
        public float Y { get; private set; }
        public float Z { get; private set; }
        public Vector3 Position { get { return new Vector3(X, Y, Z); } }
        public int Color { get; private set; }

        public LoadTerrainVertex(string data)
        {
            InitiateFromString(data);
        }

        private void InitiateFromString(string data)
        {
            data = data.Substring(1, data.Length - 2);
            var splitted = data.Split(':');

            X = float.Parse(splitted[0]);
            Y = float.Parse(splitted[1]);
            Z = float.Parse(splitted[2]);
            Color = int.Parse(splitted[3]);
        }

        public CustomVertex.PositionColored ToColoredVertex()
        {
            return new CustomVertex.PositionColored(Position, Color);
        }
    }
}
