using System;

namespace StepwiseBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = CarBuilder.Create()
                .OfType(CarType.Crossover)
                .WithWheels(18)
                .Build();
            Console.WriteLine(car);
        }
    }
}
