using CGProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGProject.Filters
{
    public class InversionFilter : IImageFilter
    {
        public PixelColor[,] ApplyFilter(PixelColor[,] pixels)
        {
            int width = pixels.GetLength(0);
            int height = pixels.GetLength(1);

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    PixelColor pixel = pixels[x, y];
                    pixels[x, y] = new PixelColor(
                        (byte)(255 - pixel.R),
                        (byte)(255 - pixel.G),
                        (byte)(255 - pixel.B)
                    );
                }
            }

            return pixels;
        }
    }
}
