using CGProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGProject.Filters
{
    public class ErrorDiffusion(double[,] kernel, double divisor, int anchorX, int anchorY, int k, bool isGrayscale) : IImageFilter
    {
        private readonly double[,] kernel = kernel;
        private readonly double divisor = divisor;
        private readonly int anchorX = anchorX;
        private readonly int anchorY = anchorY;
        private readonly int k = k;
        private readonly bool isGrayscale = isGrayscale;

        public virtual PixelColor[,] ApplyFilter(PixelColor[,] pixels)
        {
            int width = pixels.GetLength(0);
            int height = pixels.GetLength(1);

            PixelColor[,] result = (PixelColor[,])pixels.Clone();

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    PixelColor oldPixel = result[x, y];

                    if (isGrayscale)
                    {
                        byte newVal = Quantize(oldPixel.R, k);
                        result[x, y] = new PixelColor(newVal, newVal, newVal);
                        int error = oldPixel.R - newVal;
                        SpreadError(result, x, y, error, error, error);
                    }
                    else
                    {
                        byte newR = Quantize(oldPixel.R, k);
                        byte newG = Quantize(oldPixel.G, k);
                        byte newB = Quantize(oldPixel.B, k);

                        result[x, y] = new PixelColor(newR, newG, newB);

                        int errR = oldPixel.R - newR;
                        int errG = oldPixel.G - newG;
                        int errB = oldPixel.B - newB;

                        SpreadError(result, x, y, errR, errG, errB);
                    }
                }
            }

            return result;
        }

        private byte Quantize(byte value, int k)
        {
            int stepSize = 255 / (k - 1);
            return (byte)(Math.Round(value / (double)stepSize) * stepSize);
        }

        private void SpreadError(PixelColor[,] pixels, int x, int y, int errR, int errG, int errB)
        {
            int width = pixels.GetLength(0);
            int height = pixels.GetLength(1);

            for (int ky = 0; ky < kernel.GetLength(1); ky++)
            {
                for (int kx = 0; kx < kernel.GetLength(0); kx++)
                {
                    int pixelX = x + kx - anchorX;
                    int pixelY = y + ky - anchorY;

                    if (pixelX >= 0 && pixelX < width && pixelY >= 0 && pixelY < height)
                    {
                        double weight = kernel[kx, ky] / divisor;
                        if (weight != 0)
                        {
                            PixelColor neighbor = pixels[pixelX, pixelY];

                            byte newR = (byte)Math.Clamp(neighbor.R + errR * weight, 0, 255);
                            byte newG = (byte)Math.Clamp(neighbor.G + errG * weight, 0, 255);
                            byte newB = (byte)Math.Clamp(neighbor.B + errB * weight, 0, 255);

                            pixels[pixelX, pixelY] = new PixelColor(newR, newG, newB);
                        }
                    }
                }
            }
        }
    }
}
