using System;

namespace InnerFactory
{
    public class Point
    {
        private double x, y;

        private Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public static class Factory
        {
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
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var p1 =  Point.Factory.NewCartesianPoint(2, 3);
            var p2 = Point.Factory.NewPolarPoint(1.0, Math.PI / 2);
        }
    }
}
