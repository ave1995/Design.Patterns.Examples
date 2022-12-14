using DesignPatterns.Flyweight.RepeatingUserNames;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Flyweight
{
    public static class FlyweightInitialization
    {
        public static void RepeatingUserNames()
        {
            new Demo().TestUser();
            new Demo().TestUser2();
        }
    }
}
