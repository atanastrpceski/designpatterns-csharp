using System;
using System.Collections.Generic;

namespace ObserverViaDotNet
{
    public class Event
    {

    }

    public class FallsIllEvent : Event
    {
        public string Address;
    }

    public class Person : IObservable<Event>
    {
        private readonly HashSet<Subscription> subscriptions = new();

        public IDisposable Subscribe(IObserver<Event> observer)
        {
            var subscription = new Subscription(this, observer);
            subscriptions.Add(subscription);
            return subscription;
        }

        public void CatchACold()
        {
            foreach (var sub in subscriptions)
                sub.Observer.OnNext(new FallsIllEvent { Address = "123 London Road" });
        }

        private class Subscription : IDisposable
        {
            private readonly Person _person; // <- IObservable<Event>
            public readonly IObserver<Event> Observer;

            public Subscription(Person person, IObserver<Event> observer)
            {
                _person = person;
                Observer = observer;
            }

            public void Dispose()
            {
                _person.subscriptions.Remove(this);
            }
        }
    }

    internal class Program : IObserver<Event>
    {
        static void Main(string[] args)
        {
            new Program();

            Console.ReadKey();
        }

        public Program()
        {
            var person = new Person();
            IDisposable subscription = person.Subscribe(this);

            person.CatchACold();
        }

        public void OnCompleted()
        {
            // Not interested
        }

        public void OnError(Exception error)
        {
            Console.WriteLine(error.Message);
        }

        public void OnNext(Event value)
        {
            if (value is FallsIllEvent args)
            {
                Console.WriteLine($"A doctor is needed at {args.Address}");
            }
        }
    }
}
