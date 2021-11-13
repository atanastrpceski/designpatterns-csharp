using System;

namespace Example
{
    public class PersonFactory
    {
        private int _items = 0;
        public Person CreatePerson(string name)
        {
            var person = new Person()
            {
                Id = _items,
                Name = name
            };
            _items++;
            return person;
        }
    }

    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var factory = new PersonFactory();
            Console.WriteLine(factory.CreatePerson("Test1"));
            Console.WriteLine(factory.CreatePerson("Test2"));
        }
    }
}
