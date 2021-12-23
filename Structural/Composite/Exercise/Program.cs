using System;
using System.Collections;
using System.Collections.Generic;

namespace Exercise
{
    public interface IValueContainer : IEnumerable<int>
    {

    }

    public class SingleValue : IValueContainer
    {
        public int Value;
        public IEnumerator<int> GetEnumerator()
        {
            yield return this.Value;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            yield return GetEnumerator();
        }
    }

    public static class ExtensionMethods
    {
        public static int Sum(this List<IValueContainer> containers)
        {
            int result = 0;
            foreach (var c in containers)
            foreach (var i in c)
                result += i;
            return result;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var singleValue = new SingleValue { Value = 5 };
            var singleValueTwo = new SingleValue { Value = 4 };

            var listValues = new List<IValueContainer> { singleValue, singleValueTwo };

            int result = listValues.Sum();
            Console.WriteLine(result);
        }
    }
}
