using System;
using System.Collections;
using System.Drawing;
using System.Formats.Asn1;
using System.Threading;

namespace lab9_v9.Class
{
    public class Toy : Commodity
    {
        // Fields
        private double _tradeMargin { get; set; }
        public double TradeMargin => _tradeMargin;
        

        public Toy(){}
        public Toy(string name, Int32 cost, string brand, Color color, Int32 size,
            string style, bool isInStoke, Int32 retailPrice, double tradeMargin) :
            
            base(name, cost, brand, color, size, style, isInStoke)
        {
            InternalId = Interlocked.Increment(ref NextId);
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
        public new class CompareBySize: IComparer
        {
            public int Compare(object obj1, object obj2)
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
            Console.WriteLine("Name - Brand - Color - Size - Style - Cost - Retail price - Is in stoke -  ");
            return $"{this.InternalId}, {this.Name}, {this.Brand}, {this.Color}, {this.Size}, {this.Style}, {this.Cost}, {Cost + (Cost * _tradeMargin)}, {this.IsInStoke}";
        }
        // string name, Int32 cost, string brand, Color color, Int32 size, string style, bool isInStoke, Int32 retailPrice, double tradeMargin
    }
}