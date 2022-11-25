using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SOLID.OpenClosedPrinciple
{
    public class MultipleSpecifications<T> : ISpecification<T>
    {
        private IEnumerable<ISpecification<T>> _specifications;

        public MultipleSpecifications(IEnumerable<ISpecification<T>> specifications)
        {
            _specifications = specifications;
        }

        public bool IsSatisfied(T item)
        {
            bool isSatisfied = true;
            foreach (var specification in _specifications)
            {
                isSatisfied &= specification.IsSatisfied(item);
                if (!isSatisfied) return isSatisfied;
            }
            return isSatisfied;
        }
    }
}
