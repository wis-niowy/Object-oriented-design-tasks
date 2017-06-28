using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A2.CustomCollections;

namespace A2.Iterators
{
    public interface IIterator
    {
        bool hasNext();
        Object next();
    }

    class VariationsIterator : IIterator
    {
        private List<double> itemsList;
        private int leftIdx;
        private int rightIdx;

        public VariationsIterator(IIterator it1, IIterator it2, IIterator it3)
        {
            leftIdx = 0;
            rightIdx = 1;
            itemsList = new List<double>();
            while (it1.hasNext())
                itemsList.Add(double.Parse(it1.next().ToString()));
            while (it2.hasNext())
                itemsList.Add(double.Parse(it2.next().ToString()));
            while (it3.hasNext())
                itemsList.Add((double)it3.next());

        }

        public bool hasNext()
        {
            if (leftIdx < itemsList.Count - 1)
                return true;
            else return false;
        }
        public Object next()
        {
            if (rightIdx == itemsList.Count)
            {
                leftIdx++;
                if (!hasNext()) return null;
                rightIdx = leftIdx + 1;
            }
            Tuple<double, double> result = new Tuple<double, double>(itemsList[leftIdx], itemsList[rightIdx]);
            rightIdx++;
            return result;
        }

    }

    class DifferencesIterator: IIterator
    {
        IIterator variationsIterator;

        public DifferencesIterator(IIterator variationsIt)
        {
            variationsIterator = variationsIt;
        }
        public bool hasNext()
        {
            return variationsIterator.hasNext();
        }
        public Object next()
        {
            if (!variationsIterator.hasNext()) return null;
            Tuple<double, double> result = (Tuple<double, double>)variationsIterator.next();
            return result.Item1 - result.Item2;
        }
    }
}
