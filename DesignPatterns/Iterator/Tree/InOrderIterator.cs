using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Iterator.Tree
{
    public class InOrderIterator<T>
    {
        public Node<T> Current { get; set; }
        private readonly Node<T> root;
        private bool yieldedStart;

        public InOrderIterator(Node<T> root)
        {
            this.root = Current = root;
            while (Current.Left != null)
                Current = Current.Left;
        }
        public void Reset()
        {
            Current = root;
            yieldedStart = true;
        }

        public bool MoveNext()
        {
            if (!yieldedStart)
            {
                yieldedStart = true;
                return true;
            }

            if (Current.Right != null)
            {
                Current = Current.Right;
                while (Current.Left != null)
                    Current = Current.Left;
                return true;
            }
            else
            {
                var p = Current.Parent;
                while (p != null && Current == p.Right)
                {
                    Current = p;
                    p = p.Parent;
                }
                Current = p;
                return Current != null;
            }
        }
    }
}
