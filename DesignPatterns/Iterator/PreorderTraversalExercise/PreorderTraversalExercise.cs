using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Iterator.PreorderTraversalExercise
{
    public class Node<T>
    {
        public T Value;
        public Node<T> Left, Right;
        public Node<T> Parent;

        public Node(T value)
        {
            Value = value;
        }

        public Node(T value, Node<T> left, Node<T> right)
        {
            Value = value;
            Left = left;
            Right = right;

            left.Parent = right.Parent = this;
        }

        public IEnumerable<T> PreOrder
        {
            get
            {
                var tree = new BinaryTree<T>(this);
                return tree.NaturalPreOrder.Select(x => x.Value);
            }
        }
    }

    public class BinaryTree<T>
    {
        private Node<T> root;

        public BinaryTree(Node<T> root)
        {
            this.root = root;
        }

        public IEnumerable<Node<T>> NaturalPreOrder
        {
            get
            {
                IEnumerable<Node<T>> TraversePreOrder(Node<T> current)
                {
                    yield return current;
                    if (current.Left != null)
                    {
                        foreach (var left in TraversePreOrder(current.Left))
                            yield return left;
                    }
                    if (current.Right != null)
                    {
                        foreach (var right in TraversePreOrder(current.Right))
                            yield return right;
                    }
                }
                foreach (var node in TraversePreOrder(root))
                    yield return node;
            }
        }
    }
}
