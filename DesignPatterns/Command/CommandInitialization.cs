using DesignPatterns.Command.CompositeCommand;
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
            var ba = new SimpleCommand.BankAccount();
            var commands = new List<SimpleCommand.BankAccountCommand>
              {
                new SimpleCommand.BankAccountCommand(ba, SimpleCommand.BankAccountCommand.Action.Deposit, 100),
                new SimpleCommand.BankAccountCommand(ba, SimpleCommand.BankAccountCommand.Action.Withdraw, 1000)
              };

            WriteLine(ba);

            foreach (var c in commands)
                c.Call();

            WriteLine(ba);

            foreach (var c in Enumerable.Reverse(commands))
                c.Undo();

            WriteLine(ba);
        }

        public static void BankCompositeCommandInit()
        {
            var ba = new CompositeCommand.BankAccount();
            var cmdDeposit = new CompositeCommand.BankAccountCommand(ba,
              CompositeCommand.BankAccountCommand.Action.Deposit, 100);
            var cmdWithdraw = new CompositeCommand.BankAccountCommand(ba,
              CompositeCommand.BankAccountCommand.Action.Withdraw, 1000);
            cmdDeposit.Call();
            cmdWithdraw.Call();
            WriteLine(ba);
            cmdWithdraw.Undo();
            cmdDeposit.Undo();
            WriteLine(ba);


            var from = new CompositeCommand.BankAccount();
            from.Deposit(100);
            var to = new CompositeCommand.BankAccount();

            var mtc = new MoneyTransferCommand(from, to, 1000);
            mtc.Call();


            // Deposited $100, balance is now 100
            // balance: 100
            // balance: 0

            WriteLine(from);
            WriteLine(to);
        }

    }
}
