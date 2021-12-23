using System;

namespace Exercise
{
    public interface IRenderer
    {
        string WhatToRenderAs { get; }
    }

    public class RasterRenderer : IRenderer
    {
        public string WhatToRenderAs => "pixels";
    }

    public class VectorRenderer : IRenderer
    {
        public string WhatToRenderAs => "lines";
    }

    public abstract class Shape
    {
        private readonly IRenderer rendering;

        public string Name { get; set; }

        protected Shape(IRenderer rendering)
        {
            this.rendering = rendering;
        }

        public override string ToString()
        {
            return $"Drawing {Name} as {rendering.WhatToRenderAs}";
        }
    }

    public class Triangle : Shape
    {
        public Triangle(IRenderer strategy) : base(strategy) => Name = "Triangle";
    }

    public class Square : Shape
    {
        public Square(IRenderer rendering) : base(rendering) => Name = "Square";
    }

	internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Square(new VectorRenderer()).ToString());
            Console.WriteLine(new Square(new RasterRenderer()).ToString());
            Console.WriteLine(new Triangle(new VectorRenderer()).ToString());
            Console.WriteLine(new Triangle(new RasterRenderer()).ToString());
        }
    }
}
