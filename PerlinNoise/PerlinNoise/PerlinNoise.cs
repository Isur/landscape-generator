using System;
using System.Collections.Generic;
using System.Text;
using PerlinNoise;
using PerlinNoise.Config;
using PerlinNoise.Interface;

namespace PerlinNoise
{
    public class PerlinNoise : INoiseGenerator
    {
        #region Private variables

        private int gradientSize;
        private float[,,] gradient;
        private int numberOfDimensions;

        #endregion

        public PerlinNoise(int gradientSize, int numberOfDimensions)
        {
            this.gradientSize = gradientSize;
            this.numberOfDimensions = numberOfDimensions;

            generateGradient();
        }

        public float CalculateNoiseValue(int x, int z, int Size)
        {
            float y = CalculateScaledPerlin(x, z, Size);
            PerlinValueSetter.ElevateTerrainUnit(ref y);
            PerlinValueSetter.AdjustToStepness(ref y);

            return y;
        }

        #region Private methods
        private void generateGradient()
        {
            Random rand = new Random();
            int randomLimitDown = 1;
            int randomLimitUp = 100;
            float randomScale = 100.0f;
            gradient = new float[gradientSize, gradientSize, numberOfDimensions];
            for (int i = 0; i < gradientSize; i++)
            {
                for (int j = 0; j < gradientSize; j++)
                {
                    for (int k = 0; k < numberOfDimensions; k++)
                    {
                        gradient[i, j, k] = rand.Next(randomLimitDown, randomLimitUp) / randomScale;
                    }
                }
            }
        }

        private float linearInterpolationHelper(float point1, float point2, float weight)
        {
            float ret = point1 + weight * (point2 - point1);
            return ret;
        }

        private float dotGridGradient(int gradientX, int gradientY, float x, float y)
        {
            float dx = x - (float)gradientX;
            float dy = y - (float)gradientY;
            float dot = (dx * gradient[gradientY, gradientX, 0] + dy * gradient[gradientY, gradientX, 1]);
            return dot;
        }

        private float CalculateSimplePerlin(float x, float y)
        {
            // Grid cells coordinates
            int x0 = (int)x;
            int x1 = x0 + 1;
            int y0 = (int)y;
            int y1 = y0 + 1;

            // Interpolation weight
            float weightX = x - (float)x0;
            float weightY = y - (float)y0;

            // Interpolation
            float point1, point2, interpolation1, interpolation2, finallValue;
            point1 = dotGridGradient(x0, y0, x, y);
            point2 = dotGridGradient(x1, y0, x, y);
            interpolation1 = linearInterpolationHelper(point1, point2, weightX);
            point1 = dotGridGradient(x0, y1, x, y);
            point2 = dotGridGradient(x1, y1, x, y);
            interpolation2 = linearInterpolationHelper(point1, point2, weightX);
            finallValue = linearInterpolationHelper(interpolation1, interpolation2, weightY);

            return finallValue;
        }

        private float CalculateScaledPerlin(int x, int z, int Size)
        {
            float y = 0f;
            foreach (KeyValuePair<float, float> scale in PerlinParameters.Scales)
            {
                y += scale.Value * CalculateSimplePerlin((float)x / Size * scale.Key, (float)z / Size * scale.Key);
            }
            return y;
        }
        #endregion
    }
}
