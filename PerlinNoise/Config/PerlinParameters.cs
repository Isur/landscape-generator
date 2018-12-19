using System;
using System.Collections.Generic;
using System.Text;

namespace PerlinNoise.Config
{
    static class PerlinParameters
    {
        static PerlinParameters()
        {
            //<Scale, ScaleWeight>
            Scales = new Dictionary<float, float>()
            {
                {4f, 1f},
                {2.5f, 0.5f},
                {50f, 0.01f}
            };
        }

        internal static readonly Dictionary<float, float> Scales;
        internal const float power = 5.25f;
        internal const float offsetX = 100f;
        internal const float offsetZ = 100f;
    }
}
