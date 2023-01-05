using DesignPatterns.ChainOfResponsibility.BrokerChain;
using DesignPatterns.ChainOfResponsibility.ChainCodingExercise;
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
            var goblin = new MethodChain.Creature("Goblin", 2, 2);
            Console.WriteLine(goblin);

            var root = new MethodChain.CreatureModifier(goblin);

            root.Add(new NoBonusesModifier(goblin));

            Console.WriteLine("Let's double goblin's attack...");
            root.Add(new MethodChain.DoubleAttackModifier(goblin));

            Console.WriteLine("Let's increase goblin's defense");
            root.Add(new MethodChain.IncreaseDefenseModifier(goblin));

            // eventually...
            root.Handle();
            Console.WriteLine(goblin);
        }

        public static void BrokerChainInit()
        {
            BrokerChain.Game? game = new();
            var goblin = new BrokerChain.Creature(game, "Strong Goblin", 3, 3);
            Console.WriteLine(goblin);

            using (new BrokerChain.DoubleAttackModifier(game, goblin))
            {
                Console.WriteLine(goblin);
                using (new BrokerChain.IncreaseDefenseModifier(game, goblin))
                {
                    Console.WriteLine(goblin);
                }
            }

            Console.WriteLine(goblin);
        }

        public static void ChainCodingExerciseInit()
        {
            var game = new ChainCodingExercise.Game();
            var goblin = new Goblin(game);
            var goblin2 = new Goblin(game);
            var goblin3 = new GoblinKing(game);

            game.Creatures.Add(goblin);
            game.Creatures.Add(goblin2);
            game.Creatures.Add(goblin3);

            Console.WriteLine(goblin.Attack);
            Console.WriteLine(goblin.Defense);

        }
    }
}
