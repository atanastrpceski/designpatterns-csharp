using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ObservableCollection
{
    public class Market
    {
        public BindingList<float> Prices = new();

        public void AddPrice(float price)
        {
            Prices.Add(price);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var market = new Market();

            market.Prices.ListChanged += (sender, eventArgs) => // Subscribe
            {
                if (eventArgs.ListChangedType == ListChangedType.ItemAdded)
                {
                    Console.WriteLine($"Added price {((BindingList<float>)sender)[eventArgs.NewIndex]}");
                }
            };

            market.AddPrice(123);
            market.AddPrice(456);

            Console.ReadKey();
        }
    }
}
