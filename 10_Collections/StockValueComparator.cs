using System;
using System.Collections.Generic;

namespace _10_Collections
{
    internal class StockValueComparator : IComparer<IAsset>
    {
        public int Compare(IAsset first, IAsset second)
        {


            //int result = 0;
            //if (first.GetValue().CompareTo(second.GetValue()) < 0)
            //{
            //    result = 1;
            //}
            //else if (first.GetValue().CompareTo(second.GetValue()) > 0)
            //{
            //    result = -1;
            //}
            //return result;
            return second.GetValue().CompareTo(first.GetValue());

        }
    }
}