using CGProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGProject.Filters
{
    public interface IImageFilter
    {
        PixelColor[,] ApplyFilter(PixelColor[,] pixels);
    }
}
