using System;
namespace PerlinNoise
{
    public class SimplePerlinNoise
    {
        private int gradientSize;
        private float[,,] gradient;
        private int numberOfDimensions;

        public SimplePerlinNoise(int gradientSize, int numberOfDimensions)
        {
            this.gradientSize = gradientSize;
            this.numberOfDimensions = numberOfDimensions;

            generateGradient();
        }

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

        public float CalculatePerlin(float x, float y)
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
    }
}
