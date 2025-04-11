using CGProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGProject.Filters
{
    public class BrightnessFilter : IImageFilter
    {
        private int _adjustment = 30;

        //public BrightnessFilter(int adjustment)
        //{
        //    _adjustment = adjustment;
        //}

        public PixelColor[,] ApplyFilter(PixelColor[,] pixels)
        {
            int width = pixels.GetLength(0);
            int height = pixels.GetLength(1);

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    PixelColor pixel = pixels[x, y];

                    int r = Math.Clamp(pixel.R + _adjustment, 0, 255);
                    int g = Math.Clamp(pixel.G + _adjustment, 0, 255);
                    int b = Math.Clamp(pixel.B + _adjustment, 0, 255);

                    pixels[x, y] = new PixelColor((byte)r, (byte)g, (byte)b);
                }
            }

            return pixels;
        }
    }
}
