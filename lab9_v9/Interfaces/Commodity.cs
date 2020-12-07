using System;
using System.Drawing;

namespace lab9_v9.Interfaces
{
    public interface ICommodity
    {
        int InternalId { get; set; }
        string Name { get; set; }
        string Brand { get; set; }
        Color Color { get; set; }
        string Size { get; set; }
        string Style { get; set; }
        bool IsInStoke { get; set; }
    }
}