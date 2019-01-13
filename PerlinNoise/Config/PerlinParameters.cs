using System.Collections.Generic;

namespace PerlinNoise.Config
{
    public static class PerlinParameters
    {
        static PerlinParameters()
        {
            //<Scale, ScaleWeight>
            Scales = new Dictionary<float, float>()
            {
                {(float)Properties.Settings.Default.Mountainousness, 1f},
                {2.5f, 0.5f},
                {50f, 0.01f}
            };
        }

        public static readonly Dictionary<float, float> Scales;
        public static float power = 5.20f + Properties.Settings.Default.Stepness / 100f;
        internal const float offsetX = 100f;
        internal const float offsetZ = 100f;
    }
}
