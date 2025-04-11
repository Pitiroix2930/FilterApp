using CGProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGProject.Filters
{
    public class ErosionFilter : IImageFilter
    {
        public PixelColor[,] ApplyFilter(PixelColor[,] pixels)
        {
            int width = pixels.GetLength(0);
            int height = pixels.GetLength(1);

            PixelColor[,] result = new PixelColor[width, height];

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    byte minR = 255, minG = 255, minB = 255;

                    for (int ky = -1; ky <= 1; ky++)
                    {
                        for (int kx = -1; kx <= 1; kx++)
                        {
                            int pixelX = Math.Clamp(x + kx, 0, width - 1);
                            int pixelY = Math.Clamp(y + ky, 0, height - 1);

                            PixelColor neighbor = pixels[pixelX, pixelY];

                            minR = Math.Min(minR, neighbor.R);
                            minG = Math.Min(minG, neighbor.G);
                            minB = Math.Min(minB, neighbor.B);
                        }
                    }
                    result[x, y] = new PixelColor(minR, minG, minB);
                }
            }
            return result;
        }
    }

}
