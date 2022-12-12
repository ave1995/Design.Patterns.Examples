using DesignPatterns.Decorator.MultipleInheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public class DecoratorInitialization
    {
        public static void MultipleInheritanceInit()
        {
            var dragon = new Dragon { Age = 5 };

            if (dragon is IBird bird)
                bird.Fly();

            if (dragon is ILizard lizard)
                lizard.Crawl();
        }
    }
}
