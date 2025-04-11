using CGProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGProject.Filters
{
    public class ContrastFilter : IImageFilter
    {
        private double _contrast = 1.5;

        //public ContrastFilter(double contrast)
        //{
        //    _contrast = contrast;
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

                    int r = (int)Math.Clamp((pixel.R - 128) * _contrast + 128, 0, 255);
                    int g = (int)Math.Clamp((pixel.G - 128) * _contrast + 128, 0, 255);
                    int b = (int)Math.Clamp((pixel.B - 128) * _contrast + 128, 0, 255);

                    pixels[x, y] = new PixelColor((byte)r, (byte)g, (byte)b);
                }
            }

            return pixels;
        }
    }
}
