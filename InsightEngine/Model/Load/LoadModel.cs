using Microsoft.DirectX;

namespace InsightEngine.Model.Load
{
    public class LoadModel
    {
        public float X { get; private set; }
        public float Y { get; private set; }
        public float Z { get; private set; }
        public Vector3 Position { get { return new Vector3(X, Y, Z); } }
        public string Tag { get; private set; }

        public LoadModel(string data)
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
            Tag = splitted[3];
        }
    }
}
