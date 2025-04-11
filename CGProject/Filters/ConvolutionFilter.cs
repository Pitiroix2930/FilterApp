using CGProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGProject.Filters
{
    public class ConvolutionFilter : IImageFilter
    {
        private readonly double[,] kernel;
        private readonly double divisor;
        private readonly double offset;
        private readonly int anchorX;
        private readonly int anchorY;

        public ConvolutionFilter(double[,] kernel, double divisor, double offset, int anchorX, int anchorY)
        {
            this.kernel = kernel;
            this.divisor = divisor;
            this.offset = offset;
            this.anchorX = anchorX;
            this.anchorY = anchorY;
        }

        public virtual PixelColor[,] ApplyFilter(PixelColor[,] pixels)
        {
            int width = pixels.GetLength(0);
            int height = pixels.GetLength(1);
            int kernelWidth = kernel.GetLength(0);
            int kernelHeight = kernel.GetLength(1);

            PixelColor[,] result = new PixelColor[width, height];

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    double r = 0, g = 0, b = 0;

                    for (int kx = 0; kx < kernelWidth; kx++)
                    {
                        for (int ky = 0; ky < kernelHeight; ky++)
                        {
                            int pixelX = Math.Clamp(x + kx - anchorX + 1,0,width-1);
                            int pixelY = Math.Clamp(y + ky - anchorY + 1,0,height-1);

                                PixelColor pixel = pixels[Math.Clamp(pixelX,0,width-1), Math.Clamp(pixelY,0,height-1)];
                                double weight = kernel[kx, ky];

                                r += pixel.R * weight;
                                g += pixel.G * weight;
                                b += pixel.B * weight;
                            
                        }
                    }

                    r = r / divisor + offset;
                    g = g / divisor + offset;
                    b = b / divisor + offset;

                    r = Math.Clamp(r, 0, 255);
                    g = Math.Clamp(g, 0, 255);
                    b = Math.Clamp(b, 0, 255);

                    result[x, y] = new PixelColor((byte)r, (byte)g, (byte)b);
                }
            }

            return result;
        }
    }


}
