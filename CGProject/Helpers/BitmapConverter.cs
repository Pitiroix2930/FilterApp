using CGProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CGProject.Helpers
{
    public static class BitmapConverter
    {
        public static PixelColor[,] BitmapToPixelArray(Bitmap bitmap)
        {
            int width = bitmap.Width;
            int height = bitmap.Height;
            PixelColor[,] pixels = new PixelColor[width, height];

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Color color = bitmap.GetPixel(x, y);
                    pixels[x, y] = new PixelColor(color.R, color.G, color.B);
                }
            }

            return pixels;
        }

        public static Bitmap PixelArrayToBitmap(PixelColor[,] pixels)
        {
            int width = pixels.GetLength(0);
            int height = pixels.GetLength(1);
            Bitmap bitmap = new Bitmap(width, height);

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    PixelColor pixel = pixels[x, y];
                    bitmap.SetPixel(x, y, Color.FromArgb(pixel.R, pixel.G, pixel.B));
                }
            }

            return bitmap;
        }
    }
}
