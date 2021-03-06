﻿using System;
using System.Collections;
using System.Drawing;
using System.Threading;
using lab9_v9.Interfaces;

namespace lab9_v9.Class
{
    public abstract class Commodity : ICommodity, IComparable
    {
        // Fields
        protected static int NextId;
        public int InternalId { get; set; }

        public string Name { get; set; }
        public string Brand { get; set; }
        public Color Color { get; set; }
        public Int32 Size { get; set; }
        public string Style { get; set; }
        public Int32 Cost { get; set; }
        public bool IsInStoke { get; set; }
        
        
        
        protected Commodity(string name, Int32 cost, string brand, Color color, Int32 size, string style,
            bool isInStoke)
        {
            InternalId = Interlocked.Increment(ref NextId);
            Name = name;
            Cost = cost;
            Brand = brand;
            Color = color;
            Size = size;
            Style = style;
            IsInStoke = isInStoke;
        }

        // Methods 
        // IComparable --> CompareTo √
        public virtual int CompareTo(object obj)
        {
            Commodity c =  (Commodity)obj; // double casting 
            if (c.Equals(null))
            {
                throw new Exception("error: CompareTo()");
            }
            return Cost.CompareTo(c.Cost);
        }

        public static bool operator <(Commodity obj1, Commodity obj2)
        {
            return (obj1.CompareTo(obj2) < 0);
        }

        public static bool operator >(Commodity obj1, Commodity obj2)
        {
            return (obj1.CompareTo(obj2) > 0);
        }
        
        // IComparer --> by price
        public abstract class CompareByPrice: IComparer
        {
            public virtual int Compare(object obj1, object obj2)
            {
                Commodity o1 = (Commodity) obj1;
                Commodity o2 = (Commodity) obj2;
                if (o1.Cost < o2.Cost) return 1;
                if (o1.Cost > o2.Cost) return -1;
                return 0;
            }
        } 
    
        // IComparer --> by size
        public class CompareBySize: IComparer
        {
            public int Compare(object obj1, object obj2)
            {
                Commodity o1 = (Commodity) obj1;
                Commodity o2 = (Commodity) obj2;
                if (o1.Size < o2.Size) return 1;
                if (o1.Size > o2.Size) return -1;
                return 0;
            }
        }
    }
    
}
