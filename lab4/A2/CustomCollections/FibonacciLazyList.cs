using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2.CustomCollections
{
    class FibonacciLazyList : ICustomCollection<Double>
    {
        private List<double> values;
        private int sizeLimit;

        public int Size
        {
            get { return sizeLimit; }
        }

        public FibonacciLazyList(int sizeLimit)
        {
            this.values = new List<double>();
            this.sizeLimit = sizeLimit;
        }

        public double Get(int n)
        {
            double result = n;
            if (n > 1)
            {
                if (n < values.Count)
                {
                    result = values[n];
                }
                else
                {
                    result = Get(n - 1) + Get(n - 2);
                    values.Add(result);
                }
            }

            return result;
        }
        public Iterators.IIterator GetIterator()
        {
            return new FibonacciLayzListIterator(this);
        }

        private class FibonacciLayzListIterator : Iterators.IIterator
        {
            private int count;
            private FibonacciLazyList fll;

            public FibonacciLayzListIterator(FibonacciLazyList arg)
            {
                fll = arg;
                this.count = 0;
            }

            public bool hasNext()
            {
                if (count < fll.sizeLimit)
                    return true;
                else return false;
            }
            public Object next()
            {
                if (count % 2 != 0)
                {
                    count++;
                }
                double result = fll.Get(count);
                count++;
                return result;
            }
        }
    }
}
