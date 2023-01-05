using DesignPatterns.ChainOfResponsibility.MethodChain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility
{
    public static class ChainOfResponsibilityInitialization
    {

        public static void MethodChainInit()
        {
            var goblin = new Creature("Goblin", 2, 2);
            Console.WriteLine(goblin);

            var root = new CreatureModifier(goblin);

            root.Add(new NoBonusesModifier(goblin));

            Console.WriteLine("Let's double goblin's attack...");
            root.Add(new DoubleAttackModifier(goblin));

            Console.WriteLine("Let's increase goblin's defense");
            root.Add(new IncreaseDefenseModifier(goblin));

            // eventually...
            root.Handle();
            Console.WriteLine(goblin);
        }
    }
}
