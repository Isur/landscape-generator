using Microsoft.DirectX;

namespace InsightEngine
{
    public sealed class Transform
    {
        public Vector3 Position { get; set; }
        public Vector3 Rotation { get; set; }

        public Transform()
        {
            Position = new Vector3();
            Rotation = new Vector3();
        }

        public Transform(Vector3 position) : this()
        {
            Position = position;
        }

        public Transform(float x, float y, float z) :
            this(new Vector3(x, y, z))
        {

        }
    }
}
