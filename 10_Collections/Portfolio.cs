using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;

namespace _10_Collections
{
    internal class Portfolio
    {
        public List<IAsset> stocks;
        public IAsset classInstance;

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

        public void AddAsset(Stock stockHP)
        {
            stocks.Add(classInstance);
        }

        //public void AddAsset(IAsset Stock)
        //{
        //    this.Assets.Add(Stock);
        //}

        internal IList<IAsset> GetAssets()
        {
            throw new NotImplementedException();
        }

        internal IAsset GetAssetByName(string name)
        {
            IAsset element = null;
            foreach(IAsset asset in stocks)
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
            throw new NotImplementedException();
        }
    }
}