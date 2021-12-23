using System;

namespace ObserverViaEvent
{
    public class FallsIllEventArgs
    {
        public string Address;
    }

    public class Person
    {
        public event EventHandler<FallsIllEventArgs> FallsIll;

        public void CatchACold()
        {
            FallsIll?.Invoke(this,
                new FallsIllEventArgs { Address = "123 London Road" });
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.FallsIll += Person_FallsIll;

            person.CatchACold();
            Console.ReadKey();
        }

        private static void Person_FallsIll(object sender, FallsIllEventArgs e)
        {
            Console.WriteLine($"A doctor has been called to {e.Address}");
        }
    }
}
