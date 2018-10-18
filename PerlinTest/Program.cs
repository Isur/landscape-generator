using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerlinTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var perlin = new PerlinNoise();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine(perlin.Get(i/100f, j/100f));
                }
            }

            Console.ReadKey();
        }
    }

    class PerlinNoise
    {
        const int SIZE = 100;
        float[,,] gradient = new float[SIZE, SIZE, 2];

        public PerlinNoise()
        {
            Random rand = new Random();
            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        gradient[i, j, k] = rand.Next(1, 100) / 100.0f;
                    }
                }
            }
        }

        float lerp(float a0, float a1, float w)
        {

            return a0 + w * (a1 - a0);
        }
        float dotGridGradient(int ix, int iy, float x, float y)
        {
            float dx = x - (float)ix;
            float dy = y - (float)iy;

            return (dx * gradient[iy, ix, 0] + dy * gradient[iy, ix, 1]);
        }

        public float Get(float x, float y)
        {
            int x0 = (int)x;
            int x1 = x0 + 1;
            int y0 = (int)y;
            int y1 = y0 + 1;

            float sx = x - (float)x0;
            float sy = y - (float)y0;

            float n0, n1, ix0, ix1, value;
            n0 = dotGridGradient(x0, y0, x, y);
            n1 = dotGridGradient(x1, y0, x, y);
            ix0 = lerp(n0, n1, sx);
            n0 = dotGridGradient(x0, y1, x, y);
            n1 = dotGridGradient(x1, y1, x, y);
            ix1 = lerp(n0, n1, sx);
            value = lerp(ix0, ix1, sy);
            return value;


        }
    }
}
