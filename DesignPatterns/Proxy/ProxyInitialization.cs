using DesignPatterns.Proxy.PropertyProxy;
using DesignPatterns.Proxy.ProtectionProxy;
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
    }
}
