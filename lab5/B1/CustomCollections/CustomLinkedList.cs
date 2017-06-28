using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IteratorZad.Iterators;

namespace Game.CustomCollections
{
    class CustomLinkedList<T> : ICustomCollection<T>
    {
        private LinkedNode<T> head;
        private LinkedNode<T> tail;
        private int length = 0;

        public void Add(T value)
        {
            LinkedNode<T> newNode = new LinkedNode<T>(value);
            if (head == null)
            {
                head = newNode;
                tail = head;
            }
            else
            {
                tail.Next = newNode;
                newNode.Prev = tail;
                tail = newNode;
            }
            length++;
        }

        public int Size
        {
            get
            {
                return length;
            }
        }

        public IIterator GetIterator()
        {
            return new CustomLinkedListIterator(this);
        }

        private class CustomLinkedListIterator: IIterator
        {
            private CustomLinkedList<T> myList;
            private LinkedNode<T> currentEl;
            private int counter;
            public CustomLinkedListIterator(CustomLinkedList<T> arg)
            {
                myList = arg;
                currentEl = myList.tail;
                counter = 0;
            }

            public bool hasNext()
            {
                if (counter < myList.Size)
                    return true;
                else return false;
            }

            public Object next()
            {
                LinkedNode<T> toReturn = currentEl;
                if (currentEl.Prev != null) currentEl = currentEl.Prev;
                counter++;
                return toReturn.Value;
            }
        }
    }
}
