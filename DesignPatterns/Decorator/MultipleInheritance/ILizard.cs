using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.MultipleInheritance
{
    public interface ILizard : ICreature
    {
        public void Crawl()
        {
            if (Age < 10)
                Console.WriteLine("I am crawling!");
        }
    }
}
