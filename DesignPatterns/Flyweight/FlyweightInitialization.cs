using DesignPatterns.Flyweight.RepeatingUserNames;
using DesignPatterns.Flyweight.TextFormatting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Flyweight
{
    public static class FlyweightInitialization
    {
        public static void RepeatingUserNamesInit()
        {
            new Demo().TestUser();
            new Demo().TestUser2();
        }

        public static void TextFormatingInit()
        {
            var ft = new FormattedText("This is a brave new world");
            ft.Capitalize(10, 15);
            Console.WriteLine(ft);

            var bft = new BetterFormattedText("This is a brave new world");
            bft.GetRange(10, 15).Capitalize = true;
            Console.WriteLine(bft);
        }
    }
}
