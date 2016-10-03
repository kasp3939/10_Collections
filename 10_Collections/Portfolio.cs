using System;
using System.Collections.Generic;

namespace _10_Collections
{
    internal class Portfolio : IAsset
    {
        public List<IAsset> stocks;
        //public IAsset classInstance;
        public object Assets { get; private set; }

        public Portfolio()
        {
            stocks = new List<IAsset>();
        }

        public Portfolio(List<IAsset> stocks)
        {
            this.stocks = stocks;
        }

        public double GetTotalValue()
        {
            double totalv = 0;

            foreach (IAsset stock in stocks)

            {
                totalv += stock.GetValue();
            }

            return totalv;

        }

        public void AddAsset(IAsset classInstance)
        {
            stocks.Add(classInstance);
        }

        internal IList<IAsset> GetAssets()
        {
            return stocks;
        }

        //public void AddAsset(SavingsAccount cd1000)
        //{
        //    stocks.Add(classInstance);
        //}

        internal IAsset GetAssetByName(string name)
        {
            IAsset element = null;
            foreach (IAsset asset in stocks)
            {
                if (asset.GetName().Equals(name))
                { element = asset; }
            }
            return element;
        }

        internal IList<IAsset> GetAssetsSortedByName()
        {
            stocks.Sort(new StockNameComparator());
            return stocks;
        }

        internal IList<IAsset> GetAssetsSortedByValue()
        {
            stocks.Sort(new StockValueComparator());
            return stocks;
        }

        public double GetValue()
        {
            throw new NotImplementedException();
        }

        public string GetName()
        {
            throw new NotImplementedException();
        }
    }
}