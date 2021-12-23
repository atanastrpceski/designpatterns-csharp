using System;

namespace Exercise
{
    public class CombinationLock
    {
        private readonly int[] combination;

        public CombinationLock(int[] combination)
        {
            this.combination = combination;
            Reset();
        }

        private void Reset()
        {
            Status = "LOCKED";
            digitsEntered = 0;
            failed = false;
        }

        public string Status;

        private int digitsEntered = 0;
        private bool failed = false;

        public void EnterDigit(int digit)
        {
            if (Status == "LOCKED") 
                Status = string.Empty;

            Status += digit.ToString();
            if (combination[digitsEntered] != digit)
            {
                failed = true;
            }
            digitsEntered++;

            if (digitsEntered == combination.Length)
                Status = failed ? "ERROR" : "OPEN";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var cl = new CombinationLock(new[] { 1, 2, 3, 4, 5 });
            Console.WriteLine(cl.Status);
        }
    }
}
