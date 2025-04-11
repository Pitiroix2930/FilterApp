using CGProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGProject.Filters
{
    public class GammaCorrectionFilter : IImageFilter
    {
        private double _gamma = 2.2;

        //public GammaCorrectionFilter(double gamma)
        //{
        //    _gamma = gamma;
        //}

        public PixelColor[,] ApplyFilter(PixelColor[,] pixels)
        {
            int width = pixels.GetLength(0);
            int height = pixels.GetLength(1);

            byte[] gammaTable = new byte[256];
            for (int i = 0; i < 256; i++)
            {
                gammaTable[i] = (byte)Math.Clamp(255 * Math.Pow(i / 255.0, 1 / _gamma), 0, 255);
            }

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    PixelColor pixel = pixels[x, y];
                    pixels[x, y] = new PixelColor(
                        gammaTable[pixel.R],
                        gammaTable[pixel.G],
                        gammaTable[pixel.B]
                    );
                }
            }

            return pixels;
        }
    }
}
