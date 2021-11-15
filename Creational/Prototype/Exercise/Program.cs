using System;

namespace Exercise
{
    public class Point
    {
        public int X, Y;
    }

    public class Line
    {
        public Point Start, End;

        public Line DeepCopy()
        {
            var line = new Line
            {
                Start = new Point
                {
                    X = this.Start.X,
                    Y = this.Start.Y
                },
                End = new Point
                {
                    X = this.End.X,
                    Y = this.End.Y
                }
            };

            return line;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
