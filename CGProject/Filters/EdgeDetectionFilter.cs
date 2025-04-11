using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGProject.Filters
{
    public class EdgeDetectionFilter : ConvolutionFilter
    {
        public EdgeDetectionFilter()
            : base(
                new double[,]
                {
                { -1, -1, -1 },
                { -1,  8, -1 },
                { -1, -1, -1 }
                },
                divisor: 1,
                offset: 0,
                anchorX: 2,
                anchorY: 2)
        { }
    }
}
