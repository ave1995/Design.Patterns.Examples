using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Iterator.Tree
{
    public class BinaryTree<T>
    {
        private Node<T> root;

        public BinaryTree(Node<T> root)
        {
            this.root = root;
        }

        public InOrderIterator<T> GetEnumerator()
        {
            return new InOrderIterator<T>(root);
        }

        public IEnumerable<Node<T>> NaturalInOrder
        {
            get
            {
                IEnumerable<Node<T>> TraverseInOrder(Node<T> current)
                {
                    if (current.Left != null)
                    {
                        foreach (var left in TraverseInOrder(current.Left))
                            yield return left;
                    }
                    yield return current;
                    if (current.Right != null)
                    {
                        foreach (var right in TraverseInOrder(current.Right))
                            yield return right;
                    }
                }
                foreach (var node in TraverseInOrder(root))
                    yield return node;
            }
        }
    }
}
