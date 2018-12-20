using System;
using System.Collections.Generic;
using System.Text;

namespace PerlinNoise.Config
{
    static class PerlinValueSetter
    {
        internal static void ElevateTerrainUnit(ref float y)
        {
            y += 0.5f;
            y *= 5;
        }

        internal static void AdjustToStepness(ref float y)
        {
            y = (float)Math.Pow(y, PerlinParameters.power);
        }
    }
}
