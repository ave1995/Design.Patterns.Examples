using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.MultipleInheritance
{
    public interface IBird : ICreature
    {
        public void Fly()
        {
            if (Age <= 10)
                Console.WriteLine("I am flying!");
        }
    }
}
