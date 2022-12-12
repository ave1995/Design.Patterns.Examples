using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.CycleDetection
{
    public abstract class ShapeDecorator : Shape
    {
        protected internal readonly List<Type> types = new();
        protected internal Shape shape;

        public ShapeDecorator(Shape shape)
        {
            this.shape = shape;
            if (shape is ShapeDecorator sd)
                types.AddRange(sd.types);
        }
    }

    public abstract class ShapeDecorator<TSelf, TCyclePolicy> : ShapeDecorator
    where TCyclePolicy : ShapeDecoratorCyclePolicy, new()
    {
        protected readonly TCyclePolicy policy = new();

        public ShapeDecorator(Shape shape) : base(shape)
        {
            if (policy.TypeAdditionAllowed(typeof(TSelf), types))
                types.Add(typeof(TSelf));
        }
    }

    // can determine one policy for all classes
    public class ShapeDecoratorWithPolicy<T>
      : ShapeDecorator<T, ThrowOnCyclePolicy>
    {
        public ShapeDecoratorWithPolicy(Shape shape) : base(shape)
        {
        }
    }
}
