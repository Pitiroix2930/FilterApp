using CGProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGProject.Filters
{
    public class DilutionFilter : IImageFilter
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
                    byte maxR = 0, maxG = 0, maxB = 0;

                    for (int ky = -1; ky <= 1; ky++)
                    {
                        for (int kx = -1; kx <= 1; kx++)
                        {
                            int pixelX = Math.Clamp(x + kx, 0, width - 1);
                            int pixelY = Math.Clamp(y + ky, 0, height - 1);

                            PixelColor neighbor = pixels[pixelX, pixelY];

                            maxR = Math.Max(maxR, neighbor.R);
                            maxG = Math.Max(maxG, neighbor.G);
                            maxB = Math.Max(maxB, neighbor.B);
                        }
                    }
                    result[x, y] = new PixelColor(maxR, maxG, maxB);
                }
            }

            return result;
        }
    }

}
