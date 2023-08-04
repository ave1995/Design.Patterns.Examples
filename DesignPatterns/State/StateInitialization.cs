using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.State.HandmadeStateMachine;
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
    }
}
