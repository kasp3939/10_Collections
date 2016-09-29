using System;
using System.Collections;
using System.Collections.Generic;

namespace _10_Collections
{
    internal class MemoryStockRepository : IStockRepository


    {

        private long nextId;
        public void Clear()
        {
            Clear();
        }

        public ICollection FindAllStocks()
        {
            throw new NotImplementedException();
        }

        public Stock LoadStock(long id)
        {
            throw new NotImplementedException();
        }

        public long NextId()
        {
            nextId++;
            return nextId;
        }

        public void SaveStock(Stock yhoo)
        {
            throw new NotImplementedException();
        }
    }
}