using System;

namespace FactoryBulkReplacement
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory2 = new ReplaceableThemeFactory();
            var magicTheme = factory2.CreateTheme(true);
            Console.WriteLine(magicTheme.Value.BgrColor); // dark gray
            factory2.ReplaceTheme(false);
            Console.WriteLine(magicTheme.Value.BgrColor); // white
        }
    }
}
