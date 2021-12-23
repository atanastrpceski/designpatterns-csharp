using System;

namespace Exercise
{
    public interface IRectangle
    {
        int Width { get; }
        int Height { get; }
    }

    public class Square
    {
        public int Side;
    }

    public static class ExtensionMethods
    {
        public static int Area(this IRectangle rc)
        {
            return rc.Width * rc.Height;
        }
    }

    public class SquareToRectangleAdapter : IRectangle
    {
        public SquareToRectangleAdapter(Square square)
        {
            this.Height = square.Side;
            this.Width = square.Side;
        }

        public int Width { get; }
        public int Height { get; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
