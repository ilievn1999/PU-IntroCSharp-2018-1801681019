using System;

namespace GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string option;
            Console.WriteLine("Hello user! Choose an option (triangle, square or radians) :");
            option=Console.ReadLine();
            switch (option)
            {
                case "triangle":
                    Console.WriteLine("Enter a side:");
                    double side = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter a height to that side:");
                    double hside = double.Parse(Console.ReadLine());
                    Console.WriteLine($"The area of the triangle is: {TriangleArea(side, hside)}");
                    break;

                case "square":
                    Console.WriteLine("Enter a side:");
                    double aSquare = double.Parse(Console.ReadLine());
                    Console.WriteLine($"The area of the Square is: {SquareArea(aSquare)}");
                    break;

                case "radians":
                    Console.WriteLine("Enter an angle's degrees:");
                    double angle = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{angle} degrees in radians is: {AngleInRadians(angle)}");
                    break;

                default:
                    Console.WriteLine("Sorry, incorrect option! Please choose one of the above");
                    break;
            }
        }


        static double TriangleArea(double tSide, double tHeight)
        {
            double tArea = tSide * tHeight / 2;
            return tArea;
        }


        static double SquareArea(double aSqr)
        {
            double sSqr = aSqr * aSqr;
            return sSqr;
        }

        static double AngleInRadians(double angleDeg)
        {
            double angleInRadians = Math.PI / 180 * angleDeg;

            return angleInRadians;
        }
    }
}
