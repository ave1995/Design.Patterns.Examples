using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SOLID.DependencyInversionPrinciple
{
    public class Relationships : IRelationshipBrowser // low-level
    {
        private readonly List<(Person, Relationship, Person)> relations
          = new();

        public void AddParentAndChild(Person parent, Person child)
        {
            relations.Add((parent, Relationship.Parent, child));
            relations.Add((child, Relationship.Child, parent));
        }

        public List<(Person, Relationship, Person)> Relations => relations;

        public IEnumerable<Person> FindAllChildrenOf(string name)
        {
            return relations
              .Where(x => x.Item1.Name == name
                          && x.Item2 == Relationship.Parent).Select(r => r.Item3);
        }
    }

}
