using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGProject.Models
{
    public struct PixelColor
    {
        public byte R;
        public byte G;
        public byte B;

        public PixelColor(byte r, byte g, byte b)
        {
            R = r;
            G = g;
            B = b;
        }
    }
}
