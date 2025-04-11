using CGProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGProject
{
    public class PopularityQuantization
    {
        private const int GRID_SIZE = 16;

        public PixelColor[,] ApplyFilter(PixelColor[,] pixels, int k)
        {
            int width = pixels.GetLength(0);
            int height = pixels.GetLength(1);

            Dictionary<(int, int, int), List<PixelColor>> colorGrid = [];

            foreach (var pixel in pixels)
            {
                int rIndex = pixel.R / GRID_SIZE;
                int gIndex = pixel.G / GRID_SIZE;
                int bIndex = pixel.B / GRID_SIZE;

                var key = (rIndex, gIndex, bIndex);

                if (!colorGrid.ContainsKey(key))
                    colorGrid[key] = new List<PixelColor>();

                colorGrid[key].Add(pixel);
            }

            List<PixelColor> palette = [];
            foreach (var cell in colorGrid)
            {
                var mostCommonColor = cell.Value
                    .GroupBy(p => p)
                    .OrderByDescending(g => g.Count())
                    .First().Key;

                palette.Add(mostCommonColor);
            }

            palette = palette
                .OrderByDescending(c => colorGrid.Values
                .Count(list => list.Contains(c)))
                .Take(k)
                .ToList();

            PixelColor[,] result = new PixelColor[width, height];
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    var pixel = pixels[x, y];
                    var nearest = palette
                        .OrderBy(p => ColorDistance(pixel, p))
                        .First();

                    result[x, y] = nearest;
                }
            }

            return result;
        }

        private static double ColorDistance(PixelColor a, PixelColor b)
        {
            return Math.Sqrt(Math.Pow(a.R - b.R, 2) + Math.Pow(a.G - b.G, 2) + Math.Pow(a.B - b.B, 2));
        }
    }
}
