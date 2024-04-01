using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.TemplateMethod.CollectibleCardGame;

namespace DesignPatterns.TemplateMethod;
internal class TemplateMethodInitialization
{
    internal static void CollectibleCardGame()
    {
        var creatures = new Creature[]
        {
            new Creature(1, 3),
            new Creature(1, 3),
        };

        var game = new PermanentCardDamage(creatures);
        var result = game.Combat(0, 1);
    }
}
