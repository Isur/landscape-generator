using System;
using System.Collections.Generic;

namespace InsightEngine.Model.Color
{
    public class ColorManager
    {
        private List<ColorRegion> regions { get; set; }
        private int maxHeight { get; set; }
        private int minHeight { get; set; }

        private Random random { get; } = new Random();
        private int colorVariation { get; } = 15;


        public ColorManager(int maxHeight, int minHeight, List<ColorRegion> regions)
        {
            this.maxHeight = maxHeight;
            this.minHeight = minHeight;
            this.regions = regions;

            AssignRegions();
        }

        private void AssignRegions()
        {
            var range = maxHeight - minHeight;
            regions.ForEach(x => x.StartHeight =
                minHeight + (regions.LastIndexOf(x) + 1) *
                (range / regions.Count));
        }

        public int GetColor(int height)
        {
            var variation = random.Next(-20, 20);
            foreach (var region in regions)
            {
                if (height + variation > region.StartHeight)
                {
                    var r = GetColorValue(region.Color.R + random.Next(-colorVariation, colorVariation));
                    var g = GetColorValue(region.Color.G + random.Next(-colorVariation, colorVariation));
                    var b = GetColorValue(region.Color.B + random.Next(-colorVariation, colorVariation));
                    var color = System.Drawing.Color.FromArgb(r, g, b).ToArgb();
                    return color;
                }
            }

            return regions[regions.Count - 1].Color.ToArgb();
        }

        private int GetColorValue(int color)
        {
            color = color < 0 ? 0 : color;
            color = color > 255 ? 255 : color;

            return color;
        }
    }
}
