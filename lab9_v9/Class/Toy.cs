using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Formats.Asn1;
using System.Threading;

namespace lab9_v9.Class
{
    public class Toy : Commodity
    {
        // Fields
        private double _tradeMargin;
        public double TradeMargin
        {
            get => _tradeMargin;
            set => _tradeMargin = value;

        }
        // string name, Int32 cost, string brand, Color color, Int32 size,
        //string style, bool isInStoke, double tradeMargin
        public Toy(
            string name,
            Int32 cost,
            string brand,
            Color color,
            Int32 size,
            string style,
            bool isInStoke,
            double tradeMargin
            ) :
            base(name, cost, brand, color, size, style, isInStoke)
        {
            _tradeMargin = tradeMargin;
        }

            // override IComparable
        public override int CompareTo(object obj)
        {
            Toy t = (Toy) obj;
            if (t.Equals(null)) throw new Exception("CompareTo error");
            return Cost.CompareTo(t.Cost);
        }
        
        // IComparer --> compare by price or size
        public new class CompareBySize: IComparer<Toy>
        {
            public int Compare(Toy obj1, Toy obj2)
            {
                Toy o1 = (Toy) obj1;
                Toy o2 = (Toy) obj2;
                if (o1.Size < o2.Size) return 1;
                if (o1.Size > o2.Size) return -1;
                return 0;
            }
        }
        
        public new class CompareByPrice: IComparer
        {
            public int Compare(object obj1, object obj2)
            {
                Toy o1 = (Toy) obj1;
                Toy o2 = (Toy) obj2;
                if (o1.Cost < o2.Cost) return 1;
                if (o1.Cost > o2.Cost) return -1;
                return 0;
            }
        }

        public override string ToString()
        {
            return $"|------ Id ------| \t {InternalId}" +
                   $"\n|----- Name -----| \t {Name}" +
                   $"\n|----- Brand ----| \t {Brand}" +
                   $"\n|----- Color ----| \t {Color.ToKnownColor()}" +
                   $"\n|----- Size -----| \t {Size}" +
                   $"\n|----- Style ----| \t {Style}" +
                   $"\n|----- Cost -----| \t {Cost}" +
                   $"\n|- Retail price -| \t {Cost + (Cost * _tradeMargin)}" +
                   $"\n|- Is in stoke --|\t {IsInStoke}\n";
        }
    }
}