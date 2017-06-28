using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2.CustomCollections
{
    class BinaryTree : ICustomCollection<double>
    {
        private BinaryTreeNode root;
        private int treeSize = 0;

        public int Size
        {
            get { return treeSize; }
        }

        public void Add(double value)
        {
            root = add(new BinaryTreeNode(value), root);
            treeSize++;
        }

        private BinaryTreeNode add(BinaryTreeNode newNode, BinaryTreeNode subtree)
        {
            if (subtree == null)
            {
                subtree = newNode;
            }
            else {
                if (newNode.Value < subtree.Value)
                {
                    subtree.LeftChild = add(newNode, subtree.LeftChild);
                }
                else if (newNode.Value > subtree.Value)
                {
                    subtree.RightChild = add(newNode, subtree.RightChild);
                }
            }

            return subtree;
        }
        public Iterators.IIterator GetIterator()
        {
            return new BinaryTreeIterator(treeSize, root);
        }

        // klasa iteratora
        private class BinaryTreeIterator : Iterators.IIterator
        {
            private int count;
            private int treeSize;
            private int alreadyReturned;
            BinaryTreeNode root;
            Stack<BinaryTreeNode> TreeStack;
            BinaryTreeNode current;

            public BinaryTreeIterator(int size, BinaryTreeNode r)
            {
                this.count = 0;
                alreadyReturned = 0;
                TreeStack = new Stack<BinaryTreeNode>();
                this.treeSize = size;
                this.root = r;
                
            }

            public bool hasNext()
            {
                if (alreadyReturned < treeSize)
                {
                    return true;
                }
                return false;
            }
            public Object next()
            {
                TreeStack.Push(root);
                count = 0;
                alreadyReturned++;
                while (count < alreadyReturned)
                {
                    current = TreeStack.Pop();
                    count++;
                    if (current.RightChild != null) TreeStack.Push(current.RightChild);
                    if (current.LeftChild != null) TreeStack.Push(current.LeftChild);
                }
                return current;
            }
        }

        //private class 
    }
}
