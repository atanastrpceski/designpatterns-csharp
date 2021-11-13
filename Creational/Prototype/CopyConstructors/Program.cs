using System;

namespace CopyConstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            var john = new Employee("John", new Address("123 London Road", "London", "UK"));

            var chris = new Employee(john)
            {
                Name = "Chris"
            };

            Console.WriteLine(john);
            Console.WriteLine(chris);
        }
    }
}
