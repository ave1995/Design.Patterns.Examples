using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.BuilderInheritance
{
    public abstract class PersonBuilder
    {
        protected Person person = new();

        public Person Build()
        {
            return person;
        }
    }
}
