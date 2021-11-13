using System;

namespace Functional_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var pb = new PersonBuilder();
            var person = pb.Called("Dmitri").WorksAsA("Programmer").Build();

            Console.WriteLine(person);
        }
    }
}
