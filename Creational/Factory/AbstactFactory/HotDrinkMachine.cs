using System;
using System.Collections.Generic;

namespace AbstractFactory
{
    public class HotDrinkMachine
    {
        private readonly List<Tuple<string, IHotDrinkFactory>> _namedFactories = new();

        public HotDrinkMachine()
        {
            foreach (var t in typeof(HotDrinkMachine).Assembly.GetTypes())
            {
                if (typeof(IHotDrinkFactory).IsAssignableFrom(t) && !t.IsInterface)
                {
                    _namedFactories.Add(Tuple.Create(
                        t.Name.Replace("Factory", string.Empty), (IHotDrinkFactory)Activator.CreateInstance(t)));
                }
            }
        }

        public IHotDrink MakeDrink()
        {
            Console.WriteLine("Available drinks");
            for (var index = 0; index < _namedFactories.Count; index++)
            {
                var tuple = _namedFactories[index];
                Console.WriteLine($"{index}: {tuple.Item1}");
            }

            while (true)
            {
                string s;
                if ((s = Console.ReadLine()) != null
                    && int.TryParse(s, out var i) // c# 7
                    && i >= 0
                    && i < _namedFactories.Count)
                {
                    Console.Write("Specify amount: ");
                    s = Console.ReadLine();
                    if (s != null
                        && int.TryParse(s, out var amount)
                        && amount > 0)
                    {
                        return _namedFactories[i].Item2.Prepare(amount);
                    }
                }
                Console.WriteLine("Incorrect input, try again.");
            }
        }
    }
}