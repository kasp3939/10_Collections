using System;
using System.Collections;
using System.Collections.Generic;

namespace _10_Collections
{
    internal class MemoryStockRepository : IStockRepository


    {
        Dictionary<long, Stock> database = new Dictionary<long, Stock>();
        private long nextId;
        public void Clear()
        {
            database.Clear();
        }

        public ICollection FindAllStocks()
        {
            return database;
        }

        public Stock LoadStock(long id)
        {
            if(database.ContainsKey(id)) return database[id];
			else return null;
        }

        public long NextId()
        {
            nextId++;
            return nextId;
        }

        public void SaveStock(Stock stock)
        {
            database.Add(nextId, stock);
            NextId();
        }
    }
}