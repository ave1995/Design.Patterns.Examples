using DesignPatterns.Iterator.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DesignPatterns.Iterator
{
    public class IteratorInitialization
    {
        public static void TreeIteratorInit()
        {
            //     1
            //    / \
            //   2   3
            //  / \
            // 4   5
            //    / \
            //   6   7
            // in-order:  213
            // preorder:  123
            // postorder: 231

            var root = new Node<int>(1,
              new Node<int>(2, new Node<int>(4), new Node<int>(5, new Node<int>(6), new Node<int>(7))), new Node<int>(3));

            // C++ style
            var it = new InOrderIterator<int>(root);

            while (it.MoveNext())
            {
                Write(it.Current.Value);
                Write(',');
            }
            WriteLine();

            // C# style
            var tree = new BinaryTree<int>(root);

            WriteLine(string.Join(",", tree.NaturalInOrder.Select(x => x.Value)));

            // duck typing!
            foreach (var node in tree)
                WriteLine(node.Value);
        }

        public static void TreePreOrderInit()
        {
            //     1
            //    / \
            //   2   3
            //  / \
            // 4   5
            //    / \
            //   6   7
            // in-order:  213
            // preorder:  123
            // postorder: 231

            var root = new PreorderTraversalExercise.Node<int>(1,
              new PreorderTraversalExercise.Node<int>(2, new PreorderTraversalExercise.Node<int>(4), new PreorderTraversalExercise.Node<int>(5, new PreorderTraversalExercise.Node<int>(6), new PreorderTraversalExercise.Node<int>(7))), new PreorderTraversalExercise.Node<int>(3));
           
            WriteLine(string.Join(",", root.PreOrder.ToList()));
        }
    }
}
