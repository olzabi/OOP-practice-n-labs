using System;
using System.Drawing;

namespace lab9_v9.Interfaces
{
    public interface ICommodity
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
    }
}