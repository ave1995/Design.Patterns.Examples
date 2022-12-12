using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.MultipleInheritance
{
    public class Dragon : ILizard, IBird
    {
        public int Age { get; set; }
    }
}
