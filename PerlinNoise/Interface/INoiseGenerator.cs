using System;
using System.Collections.Generic;
using System.Text;

namespace PerlinNoise.Interface
{
    public interface INoiseGenerator
    {
        float CalculateNoiseValue(int x, int z, int Size);
    }
}
