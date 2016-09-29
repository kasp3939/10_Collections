using System;
using System.Collections.Generic;

namespace _10_Collections
{
    internal class StockNameComparator:IComparer <IAsset>
    {
        public StockNameComparator()
        {
        }

        public int Compare(IAsset first, IAsset second)
        {
            //int result = 0;
            //if (first.GetName().CompareTo(second.GetName())>0)
            //{
            //    result= 1;
            //}
            //else if (first.GetName().CompareTo(second.GetName()) < 0)
            //{
            //    result = -1;
            //}
            //return result;
            return first.GetName().CompareTo(second.GetName());

            //easy solution: return first.GetName().CompareTo(second.GetName())
        }
    }
}