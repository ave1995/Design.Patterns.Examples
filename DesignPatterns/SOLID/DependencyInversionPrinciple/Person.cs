using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SOLID.DependencyInversionPrinciple
{
    public enum Relationship
    {
        Parent,
        Child,
        Sibling
    }
    public class Person
    {
        public string Name;
        //public DateTime DateOfBirth;
    }
}
