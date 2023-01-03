using DesignPatterns.Proxy.BitFraging;
using DesignPatterns.Proxy.DynamicProxy;
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

        public static void SoACompositeProxyInit()
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

        public static void DynamicProxyInit()
        {
            //var ba = new BankAccount();
            var ba = Log<BankAccount>.As<IBankAccount>();

            ba.Deposit(100);
            ba.Withdraw(50);

            Console.WriteLine(ba);
        }

        public static void BitFragingInit()
        {
            var numbers = new[] { 1, 3, 5, 7 };
            int numberOfOps = numbers.Length - 1;

            for (int result = 0; result <= 10; ++result)
            {
                for (var key = 0UL; key < (1UL << 2 * numberOfOps); ++key)
                {
                    var tbs = new TwoBitSet(key);
                    var ops = Enumerable.Range(0, numberOfOps)
                      .Select(i => tbs[i]).Cast<Op>().ToArray();
                    var problem = new Problem(numbers, ops);
                    if (problem.Eval() == result)
                    {
                        Console.WriteLine($"{new Problem(numbers, ops)} = {result}");
                        break;
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
