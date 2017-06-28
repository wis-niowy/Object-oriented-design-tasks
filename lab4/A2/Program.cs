using A2.CustomCollections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2
{
    class Program
    {
        static void Main(string[] args)
        {
            ICustomCollection<double> binaryTree1 = initTree1();
            ICustomCollection<double> binaryTree2 = initTree2();
            ICustomCollection<double> fibonacci = new FibonacciLazyList(5);

            Console.WriteLine("---------------------- 1 -----------------------");
            Iterators.IIterator tree1iterator = binaryTree1.GetIterator();
            while (tree1iterator.hasNext())
            {
                Console.WriteLine("{0}", tree1iterator.next());
            }
            Console.WriteLine();
            Iterators.IIterator tree2iterator = binaryTree2.GetIterator();
            while (tree2iterator.hasNext())
            {
                Console.WriteLine("{0}", tree2iterator.next());
            }

            Console.WriteLine("---------------------- 2 -----------------------");
            Iterators.IIterator fibonacciIterator = fibonacci.GetIterator();
            while (fibonacciIterator.hasNext())
            {
                Console.WriteLine("{0}", fibonacciIterator.next());
            }

            Console.WriteLine("---------------------- 3 -----------------------");
            Iterators.IIterator variationsIterator = new Iterators.VariationsIterator(binaryTree1.GetIterator(), binaryTree2.GetIterator(), fibonacci.GetIterator());
            while (variationsIterator.hasNext())
            {
                Console.WriteLine("{0}", variationsIterator.next());
            }

            Console.WriteLine("---------------------- 4 -----------------------");
            Iterators.IIterator differencesIterator = new Iterators.DifferencesIterator(new Iterators.VariationsIterator(binaryTree1.GetIterator(), binaryTree2.GetIterator(), fibonacci.GetIterator()));
            while (differencesIterator.hasNext())
            {
                Console.WriteLine("{0}", differencesIterator.next());
            }

        }


        //DO NOT change code below

        static BinaryTree initTree1()
        {
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Add(7);
            binaryTree.Add(5);
            binaryTree.Add(6);
            binaryTree.Add(4);
            binaryTree.Add(3);
            binaryTree.Add(8);
            binaryTree.Add(9);

            return binaryTree;
        }

        static BinaryTree initTree2()
        {
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Add(17);
            binaryTree.Add(16);
            binaryTree.Add(14);
            binaryTree.Add(13);
            binaryTree.Add(15);
            binaryTree.Add(18);
            binaryTree.Add(19);

            return binaryTree;
        }

    }
}
