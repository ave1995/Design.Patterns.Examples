using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SOLID.DependencyInversionPrinciple
{
    public class Research
    {
        public Research(Relationships relationships)
        {
            // high-level: find all of john's children
            //var relations = relationships.Relations;
            //foreach (var r in relations
            //  .Where(x => x.Item1.Name == "John"
            //              && x.Item2 == Relationship.Parent))
            //{
            //  WriteLine($"John has a child called {r.Item3.Name}");
            //}
        }

        public Research(IRelationshipBrowser browser)
        {
            foreach (var p in browser.FindAllChildrenOf("John"))
            {
                Console.WriteLine($"John has a child called {p.Name}");
            }
        }
    }
}
