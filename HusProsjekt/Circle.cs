using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HusProsjekt
{
    internal class Circle
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }
        public double CircleArea()
        {
            var area = Math.PI * Math.Pow(Radius, 2);
            return area;
        }
    }
}
