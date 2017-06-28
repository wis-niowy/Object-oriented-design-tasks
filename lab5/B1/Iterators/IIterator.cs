using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorZad.Iterators
{
    public interface IIterator
    {
        bool hasNext();
        Object next();
    }

    public class TournamtneIterator: IIterator
    {
        List<Object> myList;
        private int counter;
        private int leftIdx;
        private int rightIdx;
        public TournamtneIterator(IIterator arg1, IIterator arg2, IIterator arg3)
        {
            myList = new List<object>();
            while (arg1.hasNext())
                myList.Add(arg1.next());
            while (arg2.hasNext())
                myList.Add(arg2.next());
            while (arg3.hasNext())
                myList.Add(arg3.next());
            counter = 0;
        }

        public bool hasNext()
        {
            if (leftIdx < myList.Count-1)
                return true;
            else return false;
        }

        public Object next()
        {
            if (!hasNext()) return null;
            if (rightIdx == myList.Count)
            {
                leftIdx++; rightIdx = 0;
            }
            Tuple<Object, Object> toReturn = new Tuple<Object, Object>(myList[leftIdx], myList[rightIdx]);
            rightIdx++;
            counter++;

            return toReturn;
        }
    }

    public class FilterIterator: IIterator
    {
        Game.Model.HeroClass cond;
        IIterator it;
        public FilterIterator(Game.Model.HeroClass condition, IIterator it)
        {
            cond = condition; this.it = it;
        }

        public bool hasNext()
        {
            return it.hasNext();
        }

        public Object next()
        {
            if (!hasNext()) return null;
            Object toReturn = it.next();
            while (((Game.Model.Hero)toReturn).HeroClass != cond)
            {
                if (!hasNext()) return null;
                toReturn = it.next();
            }
            return toReturn;
        }
    }
}
