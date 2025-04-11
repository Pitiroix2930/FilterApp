using CGProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGProject.Filters
{
    public class YCBCRFilter(double[,] kernel, double divisor, int anchorX, int anchorY, int k) : IImageFilter
    {
        private readonly double[,] kernel = kernel;
        private readonly double divisor = divisor;
        private readonly int anchorX = anchorX;
        private readonly int anchorY = anchorY;
        private readonly int k = k;

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

                    byte Yp = (byte)Math.Clamp(0.299 * result[x, y].R + 0.587 * result[x, y].G + 0.114 * result[x, y].B, 0, 255);
                    byte Cb = (byte)Math.Clamp(128 - 0.168736 * result[x, y].R - 0.331264 * result[x, y].G + 0.5 * result[x, y].B, 0, 255);
                    byte Cr = (byte)Math.Clamp(128 + 0.5 * result[x, y].R - 0.418688 * result[x, y].G - 0.081312 * result[x, y].B, 0, 255);

                    byte newVal = Quantize(Yp, k);
                    result[x, y] = new PixelColor(newVal, newVal, newVal);
                    int error = oldPixel.R - newVal;
                    SpreadError(result, x, y, error, error, error);

                    byte R = (byte)Math.Clamp(newVal + 1.402 * (Cr - 128), 0, 255);
                    byte G = (byte)Math.Clamp(newVal - 0.344136 * (Cb - 128) - 0.71436 * (Cr - 128), 0, 255);
                    byte B = (byte)Math.Clamp(newVal + 1.772 * (Cb - 128), 0, 255);

                    result[x, y] = new PixelColor(R, G, B);
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
