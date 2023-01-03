using DesignPatterns.Proxy.PropertyProxy;
using DesignPatterns.Proxy.ProtectionProxy;
using DesignPatterns.Proxy.SoACompositeProxy;
using DesignPatterns.Proxy.ValueProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy
{
    public class ProxyInitialization
    {
        public static void ProtectionProxyInit()
        {
            ICar car = new CarProxy(new Driver(12)); // 22
            car.Drive();
        }

        public static void PropertyProxyInit()
        {
            var c = new Creature();
            c.Agility = 10; // c.set_Agility(10) xxxxxxxxxxxxx
                            // c.Agility = new Property<int>(10)
            c.Agility = 10;

            Property<int> property = 5;

            int x = property;
        }

        public static void ValueProxyInit()
        {
            var x = 5.Percent();

            Console.WriteLine(10f * 5.Percent());
            Console.WriteLine(2.Percent() + 3.Percent());
        }

        public static void SoACompositeProxy()
        {
            var monsters = new Monster[100];

            for (int i = 0; i < 100; i++)
            {
                monsters[i] = new Monster();
            }

            foreach (var c in monsters)
            {
                c.X++; // not memory-efficient
            }

            var monsters2 = new Monsters(100);
            foreach (var c in monsters2)
            {
                c.X++;
            }
        }
    }
}
