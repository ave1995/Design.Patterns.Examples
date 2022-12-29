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
    }
}
