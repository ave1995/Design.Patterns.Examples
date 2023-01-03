using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy.ValueProxy
{

    [DebuggerDisplay("{value*100.0f}%")]
    public struct Percentage
    {
        private readonly float value;

        internal Percentage(float value)
        {
            this.value = value;
        }

        //    public static implicit operator Percentage(float value)
        //    {
        //      return new Percentage(value);
        //    }

        public static float operator *(float f, Percentage p)
        {
            return f * p.value;
        }

        //https://betterprogramming.pub/why-is-0-1-0-2-not-equal-to-0-3-in-most-programming-languages-99432310d476
        public static Percentage operator +(Percentage a, Percentage b)
        {
            return new Percentage(a.value + b.value);
        }

        public static implicit operator Percentage(int value)
        {
            return value.Percent();
        }

        public bool Equals(Percentage other)
        {
            return value.Equals(other.value);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is Percentage other && Equals(other);
        }

        public override int GetHashCode()
        {
            return value.GetHashCode();
        }

        public override string ToString()
        {
            return $"{value * 100}%";
        }
    }
}
