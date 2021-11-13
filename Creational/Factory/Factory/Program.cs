using System;

namespace Factory
{
    public class Point
    {
        private double _x, _y;

        public Point(double x, double y)
        {
            this._x = x;
            this._y = y;
        }

        //Factory Property
        public static Point Origin => new Point(0, 0);
    }

    class Program
    {
        static void Main(string[] args)
        {
            var p1 = PointFactory.NewCartesianPoint(2, 3);
            var origin = Point.Origin;

            var p2 = PointFactory.NewPolarPoint(1.0,  Math.PI / 2);
        }
    }
}
