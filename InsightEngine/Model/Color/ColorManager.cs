﻿using Microsoft.DirectX;
using PerlinNoise;
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
        private int colorVariation { get; } = 10;

        private const int width = 500;
        private SimplePerlinNoise perlin = new SimplePerlinNoise(width, 3);


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

        public int GetColor(Vector3 position)
        {
            var randomVariation = random.Next(-2, 2);
            var variation = (int)perlin.CalculatePerlinOctaves((int)position.X, (int)position.Z, width);//random.Next(-20, 20);
            variation /= 10;
            foreach (var region in regions)
            {
                if (position.Y + variation + randomVariation > region.StartHeight)
                {
                    var r = GetColorValue(region.Color.R + random.Next(-colorVariation, colorVariation));
                    var g = GetColorValue(region.Color.G + random.Next(-colorVariation, colorVariation));
                    var b = GetColorValue(region.Color.B + random.Next(-colorVariation, colorVariation));
                    //var r = GetColorValue(region.Color.R + variation);
                    //var g = GetColorValue(region.Color.G + variation);
                    //var b = GetColorValue(region.Color.B + variation);
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
