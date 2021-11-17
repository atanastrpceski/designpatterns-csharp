using System;

namespace Exercise
{
    class Program
    {
        public static bool IsSingleton(Func<object> func)
        {
            return func() == func();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
