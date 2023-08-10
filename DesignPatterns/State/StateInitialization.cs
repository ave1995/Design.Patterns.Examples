using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.State.HandmadeStateMachine;
using DesignPatterns.State.LockExercise;
using DesignPatterns.State.SwitchExpressions;
using static System.Console;

namespace DesignPatterns.State
{
    public class StateInitialization
    {
        public static void HandmadeStateMachineInit()
        {
            var state = HandmadeStateMachine.State.OffHook;
            var rules = HandmadeStateMachine.HandmadeStateMachine.rules;

            while (true)
            {
                WriteLine($"The phone is currently {state}");
                WriteLine("Select a trigger:");

                // foreach to for
                for (var i = 0; i < rules[state].Count; i++)
                {
                    var (t, _) = rules[state][i];
                    WriteLine($"{i}. {t}");
                }


                int input = int.Parse(Console.ReadLine());

                var (_, s) = rules[state][input];
                state = s;
            }
        }

        public static void SwitchBasedStateMachineInit()
        {
            SwitchBasedStateMachine.SwitchBasedStateMachine.Run();
        }

        public static void SwitchExpressionsInit()
        {
            Chest chest = Chest.Locked;
            Console.WriteLine($"Chest is {chest}");

            // unlock with key
            chest = SwitchExpressions.SwitchExpressions.Manipulate(chest, SwitchExpressions.Action.Open, true);
            Console.WriteLine($"Chest is now {chest}");

            // close it!
            chest = SwitchExpressions.SwitchExpressions.Manipulate(chest, SwitchExpressions.Action.Close, false);
            Console.WriteLine($"Chest is now {chest}");

            // close it again!
            chest = SwitchExpressions.SwitchExpressions.Manipulate(chest, SwitchExpressions.Action.Close, false);
            Console.WriteLine($"Chest is now {chest}");
        }

        public static void LockReader()
        {
            var combinationLock = new CombinationLock(new int[5] { 1, 2, 3, 4, 5 });

            while (true) 
            {
                WriteLine($"Status: {combinationLock.Status}");
                WriteLine("Type a number to open lock:");
                combinationLock.EnterDigit(int.Parse(Console.ReadLine()));
            }
        }
    }
}
