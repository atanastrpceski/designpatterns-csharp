using System;

namespace Exercise
{
    public class Command
    {
        public enum Action
        {
            Deposit,
            Withdraw
        }

        public Action TheAction;
        public int Amount;
        public bool Success;
    }

    public class Account
    {
        public int Balance { get; set; }

        public void Process(Command c)
        {
            switch (c.TheAction)
            {
                case Command.Action.Deposit:
                    Balance += c.Amount;
                    c.Success = true;
                    break;
                case Command.Action.Withdraw:
                    c.Success = Balance >= c.Amount;
                    if (c.Success) Balance -= c.Amount;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var a = new Account();

            var command = new Command { Amount = 100, TheAction = Command.Action.Deposit };
            a.Process(command);

            command = new Command { Amount = 50, TheAction = Command.Action.Withdraw };
            a.Process(command);

            command = new Command { Amount = 150, TheAction = Command.Action.Withdraw };
            a.Process(command);
        }
    }
}
