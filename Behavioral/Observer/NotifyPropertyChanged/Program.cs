using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace NotifyPropertyChanged
{
    public class Market : INotifyPropertyChanged
    {
        private float _volatility;

        public float Volatility
        {
            get => _volatility;
            set
            {
                if (value.Equals(_volatility)) return;
                _volatility = value;
                OnPropertyChanged();
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var market = new Market();
            market.PropertyChanged += (sender, eventArgs) =>
            {

            };
        }
    }
}
