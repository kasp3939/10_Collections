using System;

namespace _10_Collections
{
    internal class Stock : IAsset
    {
        private object obj;

        public Stock()
        {

        }

        public Stock(string v1, double v2, int v3)
        {
            Symbol = v1;
            PricePerShare = v2;
            NumShares = v3;

        }

        public Stock(object obj)
        {
            this.obj = obj;
        }

        public double NumShares
        {
            get;
            internal set;
        }
        public double PricePerShare

        {
            get;
            internal set; 
        }

        public string Symbol
        {
            get;
            internal set;                     
        }
        public int Id { get; internal set; }

        public double GetValue()
        {
            
            return NumShares * PricePerShare;
        }

        internal static double TotalValue(Stock[] stocks)
        {
     
            double sum = 0;

            foreach 
                (Stock stock in stocks)
                    { sum += stock.GetValue(); }

            return sum;
        }

        public override string ToString()
        {
            return "Stock[symbol=" + Symbol + ",pricePerShare=" + PricePerShare
                + ",numShares=" + NumShares + "]";
        }

        public override bool Equals(object obj)
        {
            Stock s = (Stock)obj;

            return 
                (Symbol == s.Symbol) &&
                (PricePerShare == s.PricePerShare) &&
                (NumShares == s.NumShares);
        }

        internal static object TotalValue(IAsset[] portfolio)
        {
            throw new NotImplementedException();
        }

        public string GetName()
        {
            return Symbol;
        }
    }
}   