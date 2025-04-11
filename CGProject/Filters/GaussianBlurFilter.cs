using CGProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGProject.Filters
{
    public class GaussianBlurFilter : ConvolutionFilter
    {
        public GaussianBlurFilter()
            : base(
                new double[,]
                {
                { 1, 2, 1 },
                { 2, 4, 2 },
                { 1, 2, 1 }
                },
                divisor: 16,
                offset: 0,
                anchorX: 2,
                anchorY: 2)
        { }
    }
}
