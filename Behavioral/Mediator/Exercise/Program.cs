using System;

namespace Exercise
{
    public class Mediator
    {
        public void Broadcast(object sender, int n)
        {
            Alert?.Invoke(sender, n);
        }

        public event EventHandler<int> Alert;
    }

    public class Participant
    {
        private readonly Mediator mediator;

        public int Value { get; set; }

        public Participant(Mediator mediator)
        {
            this.mediator = mediator;
            mediator.Alert += Mediator_Alert;
        }

        private void Mediator_Alert(object sender, int e)
        {
            if (sender != this)
                Value += e;
        }

        public void Say(int n)
        {
            mediator.Broadcast(this, n);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var mediator = new Mediator();
            var p1 = new Participant(mediator);
            var p2 = new Participant(mediator);

            p1.Say(2);
            p2.Say(4);
        }
    }
}
