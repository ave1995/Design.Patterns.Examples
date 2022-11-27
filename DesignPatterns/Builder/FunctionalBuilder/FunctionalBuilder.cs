using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.FunctionalBuilder
{
    public abstract class FunctionalBuilder<TEntity, TSelf>
        where TEntity : new()
        where TSelf : FunctionalBuilder<TEntity, TSelf>
    {
        protected readonly List<Func<TEntity, TEntity>> Actions = new();

        public TSelf Do(Action<TEntity> action) => AddAction(action);

        public TEntity Build() => Actions.Aggregate(new TEntity(), (p, f) => f(p));

        private TSelf AddAction(Action<TEntity> action)
        {
            Actions.Add(p => { action(p); return p; });
            return (TSelf)this;
        }
    }
}
