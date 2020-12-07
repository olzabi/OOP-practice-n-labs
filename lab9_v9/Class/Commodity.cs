using System;
using System.Drawing;
using System.Threading;
using lab9_v9.Interfaces;

namespace lab9_v9.Class
{
    public abstract class Commodity: ICommodity
    {
        // Fields
        private static int _nextId;
        public int InternalId { get;  set; }

        public string Name { get; set; }
        public string Brand { get; set; }
        public Color Color { get; set; }
        public string Size { get; set; }
        public string Style { get; set; }
        public bool IsInStoke { get; set; }
        
        
        // Совсем не принципиально будет ли объект иммутабельным или нет, поэтому используем две формы.
        protected Commodity() {}
        protected Commodity(string name, string brand, Color color, string size, string style, bool isInStoke)
        {
            InternalId = Interlocked.Increment(ref _nextId);
            Brand = brand;
            Color = color;
            Size = size;
            Style = style;
            IsInStoke = isInStoke;
        }
    }
}