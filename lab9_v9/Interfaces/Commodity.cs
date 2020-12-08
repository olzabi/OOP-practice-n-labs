using System;
using System.Collections;
using System.Drawing;
using lab9_v9.Class;

namespace lab9_v9.Interfaces
{
    public interface ICommodity : IComparable
    { 
        // Fields
        int InternalId { get; set; }
        string Name { get; set; }
        string Brand { get; set; }
        Color Color { get; set; }
        Int32 Size { get; set; }
        Int32 Cost { get; set; }
        string Style { get; set; }
        bool IsInStoke { get; set; }
        // Methods
        int IComparable.CompareTo(object obj)
        
        {
            Commodity c =  (Commodity)obj; // double casting 
            if (c.Equals(null))
            {
                throw new Exception("error: CompareTo()");
            }
            return Cost.CompareTo(c.Cost);
        }
    }
}