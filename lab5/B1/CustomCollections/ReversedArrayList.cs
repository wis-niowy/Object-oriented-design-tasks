using Game;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IteratorZad.Iterators;

namespace Game.CustomCollections
{
    class ReversedArrayList<T> : ICustomCollection<T>
    {
        private T[] values;
        private int length = 0;

        public ReversedArrayList()
        {
            this.values = new T[10];
        }

        public int Size
        {
            get
            {
                return length;
            }
        }

        public void Add(T value)
        {
            values[length] = value;
            if (++length == values.Length)
            {
                T[] newValues = new T[values.Length * 2];
                Array.Copy(values, 0, newValues, 0, values.Length);
                values = newValues;
            }
        }

        public T Get(int n)
        {
            if (n < 0)
            {
                // throw new Exception here
            }

            return values[length - n - 1];
        }
        public IIterator GetIterator()
        {
            return new ReversedArrayListIterator(this);
        }

        private class ReversedArrayListIterator : IIterator
        {
            private ReversedArrayList<T> myList;
            private int counter;

            public ReversedArrayListIterator(ReversedArrayList<T> arg)
            {
                myList = arg;
                counter = myList.Size-1;
            }

            public bool hasNext()
            {
                if (counter >= 0)
                    return true;
                else return false;
            }

            public Object next()
            {
                if (!hasNext()) return null;
                T toReturn = myList.Get(counter);
                counter--;
                return toReturn;
            }
        }
    }
}
