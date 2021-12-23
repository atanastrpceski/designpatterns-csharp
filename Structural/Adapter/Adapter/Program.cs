using System;
using System.Collections.Generic;

namespace Adapter
{
    internal class Program
    {
        private static readonly List<VectorObject> vectorObjects = new()
        {
            new VectorRectangle(1, 1, 10, 10),
            new VectorRectangle(3, 3, 6, 6)
        };

        // the interface we have
        public static void DrawPoint(Point p)
        {
            Console.Write(".");
        }

        private static void Draw()
        {
            foreach (var vo in vectorObjects)
            {
                foreach (var line in vo)
                {
                    var adapter = new LineToPointAdapter(line);
                    foreach (var point in adapter)
                    {
                        DrawPoint(point);
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Draw();
            Draw();

            Console.ReadKey();
        }
    }
}
