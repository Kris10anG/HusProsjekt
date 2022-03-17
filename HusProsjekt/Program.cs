using System;

namespace HusProsjekt
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var rectangular = new Rectangular(1500, 2500); //får satt verdiene 1500 0g 2500 ved hjelp av constructor
            var circle = new Circle(375);
            var triangle = new Triangle(750, 500);

            double rectangularArea = rectangular.RectangularArea();
            double circleArea = circle.CircleArea();
            double triangleArea = triangle.TriangleArea();

            double wholeArea = rectangularArea + circleArea + triangleArea;

            double nok = wholeArea * 0.43; //ganger med 0.43 for å få norsk valuta
            double roundNumber = Math.Round(nok, 2);
            Console.WriteLine("Norsk pris på huset: " + roundNumber + "Kr");
        }

    }
}
//Console.WriteLine(Rectangular(1500, 2500));
//Console.WriteLine(Circle(375));
//Console.WriteLine(Triangle(750, 500));

//Console.WriteLine(bigbrain);
//static double Rectangular(double width, double length)
//{
//    var area = width * length;
//    return area;
//}

//static double Circle(double radius)
//{
//    //var pi = Math.PI
//    var area = Math.PI * Math.Pow(radius, 2);
//    return area;
//}

//static double Triangle(double bottom, double height)
//{
//    //var area = 0.5;
//    var area = 0.5 * bottom * height;
//    return area;
//}
