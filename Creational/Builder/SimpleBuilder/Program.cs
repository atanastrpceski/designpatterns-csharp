using static System.Console;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // ordinary non-fluent builder
            var builder = new HtmlBuilder("ul");
            builder.AddChild("li", "hello");
            builder.AddChild("li", "world");
            WriteLine(builder.ToString());

            // fluent builder
            builder.Clear(); // disengage builder from the object it's building, then...
            builder.AddChildFluent("li", "hello").AddChildFluent("li", "world");
            WriteLine(builder);
        }
    }
}
