using CGProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGProject.Filters
{
    public class EmbossFilter : ConvolutionFilter
    {
        public EmbossFilter()
            : base(
                new double[,]
                {
                { -2, -1,  0 },
                { -1,  1,  1 },
                {  0,  1,  2 }
                },
                divisor: 1,
                offset: 128,
                anchorX: 2,
                anchorY: 2)
        { }
    }
}
