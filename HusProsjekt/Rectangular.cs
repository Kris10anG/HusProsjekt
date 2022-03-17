using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HusProsjekt
{
    internal class Rectangular
    {
        public double Width { get; set; }
        public double Length { get; set; }

        public Rectangular(double width, double length )
        {
            Width = width;
            Length = length;
        }
        public double RectangularArea()
        {
            var area = Width * Length;
            return area;
        }
    }
}
