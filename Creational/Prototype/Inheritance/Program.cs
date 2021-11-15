using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var john = new Employee
            {
                Names = new[] { "John", "Doe" },
                Address = new Address { HouseNumber = 123, StreetName = "London Road" },
                Salary = 321000
            };
            var copy = john.DeepCopy();

            copy.Names[1] = "Smith";
            copy.Address.HouseNumber++;
            copy.Salary = 123000;

            Console.WriteLine(john);
            Console.WriteLine(copy);
        }
    }
}
