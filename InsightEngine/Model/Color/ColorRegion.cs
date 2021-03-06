﻿namespace InsightEngine.Model.Color
{
    public class ColorRegion
    {
        public System.Drawing.Color Color { get; private set; }
        public double Weight { get; private set; }
        public int StartHeight { get; set; }

        public ColorRegion(System.Drawing.Color color, double weight)
        {
            Color = color;
            Weight = weight;
        }
    }
}
