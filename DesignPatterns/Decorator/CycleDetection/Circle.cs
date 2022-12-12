using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.CycleDetection
{
    public sealed class Circle : Shape
    {
        private float radius;

        public Circle() : this(0)
        {
        }

        public Circle(float radius)
        {
            this.radius = radius;
        }

        public void Resize(float factor)
        {
            radius *= factor;
        }

        public override string AsString() => $"A circle of radius {radius}";
    }
}
