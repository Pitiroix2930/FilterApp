using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGProject.Filters
{
    public class SharpenFilter : ConvolutionFilter
    {
        public SharpenFilter()
            : base(
                new double[,]
                {
                {  0, -1,  0 },
                { -1,  5, -1 },
                {  0, -1,  0 }
                },
                divisor: 1,
                offset: 0,
                anchorX: 2,
                anchorY: 2)
        { }
    }
}
