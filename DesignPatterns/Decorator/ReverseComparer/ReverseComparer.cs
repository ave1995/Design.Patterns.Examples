using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.ReverseComparer
{
    public class ReverseComparer<T> : IComparer<T>
    {
        public readonly IComparer<T> _other;
        public ReverseComparer(IComparer<T> other) => _other = other;
        public int Compare(T? x, T? y) => _other.Compare(y, x);

    }

    public static class Comparer
    {
        public static IComparer<T> Reverse<T>(this IComparer<T> other) =>
            other is ReverseComparer<T> reverse ? reverse._other
            : new ReverseComparer<T>(other);
    }
}
