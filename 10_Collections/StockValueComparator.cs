using System;

namespace _10_Collections
{
    public class StockValueComparator
    {
        internal int Compare(Stock first, Stock second)
        {


            int result = 0;
            if (first.GetValue().CompareTo(second.GetValue()) < 0)
            {
                result = 1;
            }
            else if (first.GetValue().CompareTo(second.GetValue()) > 0)
            {
                result = -1;
            }
            return result;
            //return second.GetValue().CompareTo(first.GetValue());

        }
    }
}