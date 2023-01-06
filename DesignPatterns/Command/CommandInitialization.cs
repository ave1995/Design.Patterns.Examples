using DesignPatterns.Command.SimpleCommand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DesignPatterns.Command
{
    public class CommandInitialization
    {
        public static void BankCommandInit()
        {
            var ba = new BankAccount();
            var commands = new List<BankAccountCommand>
              {
                new BankAccountCommand(ba, BankAccountCommand.Action.Deposit, 100),
                new BankAccountCommand(ba, BankAccountCommand.Action.Withdraw, 1000)
              };

            WriteLine(ba);

            foreach (var c in commands)
                c.Call();

            WriteLine(ba);

            foreach (var c in Enumerable.Reverse(commands))
                c.Undo();

            WriteLine(ba);
        }

    }
}
