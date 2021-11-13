using System;

namespace Factory
{
    // Factory
    public class PointFactory
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