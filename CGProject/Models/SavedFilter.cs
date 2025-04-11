using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGProject.Models
{
    public class SavedFilter
    {
        public string Name { get; set; }
        public double[,] Kernel { get; set; }
        public double Divisor { get; set; }
        public double Offset { get; set; }
        public int AnchorX { get; set; }
        public int AnchorY { get; set; }
    }
}
