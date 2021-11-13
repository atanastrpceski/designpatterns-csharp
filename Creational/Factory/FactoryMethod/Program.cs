using System;

namespace FactoryMethod
{
    public class Point
    {
        private double x, y;


        private Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        // Factory Method
        public static Point NewCartesianPoint(float x, float y)
        {
            return new Point(x, y);
        }

        // Factory Method
        public static Point NewPolarPoint(double a, double b)
        {
            var x = a * Math.Cos(b);
            var y = a * Math.Sin(b);

            return new Point(x, y);
        }

        //Factory Property
        public static Point Origin => new Point(0, 0);
    }


    class Program
    {
        static void Main(string[] args)
        {
            var p1 =  Point.NewCartesianPoint(2, 3);
            var origin = Point.Origin;

            var p2 = Point.NewPolarPoint(1.0, Math.PI / 2);
        }
    }
}
