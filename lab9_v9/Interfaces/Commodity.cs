using System;
using System.Collections;
using System.Drawing;

namespace lab9_v9.Interfaces
{
    public interface ICommodity : IComparable, IComparer, IEnumerable
    { 
        // Fields
        int InternalId { get; set; }
        string Brand { get; set; }
        Color Color { get; set; }
        Int32 Size { get; set; }
        Int32 Cost { get; set; }
        string Style { get; set; }
        bool IsInStoke { get; set; }

        string Name { get; set; }

        // Methods
        int IComparable.CompareTo(object obj);
        int IComparer.Compare(object obj1, object obj2);
        IEnumerator IEnumerable.GetEnumerator();
    }
}