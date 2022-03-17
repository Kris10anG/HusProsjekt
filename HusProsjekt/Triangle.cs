using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HusProsjekt
{
    internal class Triangle
    {
        public double Bottom { get; set; }
        public double Height { get; set; }
        public Triangle(double bottom, double height)
        {
            Bottom = bottom;
            Height = height;
        }
        public double TriangleArea()
        {
            var area = 0.5 * Bottom * Height;

            return area;
        }
    }
}
