using Autofac;

namespace Bridge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var raster = new RasterRenderer();
            var vector = new VectorRenderer();
            var circle = new Circle(vector, 5);
            circle.Draw();
            circle.Resize(2);
            circle.Draw();
        }
    }
}
