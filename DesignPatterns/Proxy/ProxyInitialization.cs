using DesignPatterns.Proxy.PropertyProxy;
using DesignPatterns.Proxy.ProtectionProxy;
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
    }
}
