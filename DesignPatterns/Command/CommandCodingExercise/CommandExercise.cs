using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command.CommandCodingExercise
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
                    Deposit(c.Amount);
                    c.Success = true;
                    break;
                case Command.Action.Withdraw:
                    c.Success = Withdraw(c.Amount);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public void Deposit(int amount)
        {
            Balance += amount;
        }

        public bool Withdraw(int amount)
        {
            if (Balance < amount)
            {
                return false;
            }

            Balance -= amount;
            return true;
        }
    }
}
