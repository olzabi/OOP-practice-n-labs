using System;
using System.Collections;
using System.Drawing;
using System.Threading;
using lab9_v9.Interfaces;

namespace lab9_v9.Class
{
    public abstract class Commodity : ICommodity
    {
        // Fields
        private static int _nextId;
        public int InternalId { get; set; }

        public string Name { get; set; }
        public string Brand { get; set; }
        public Color Color { get; set; }
        public Int32 Size { get; set; }
        public string Style { get; set; }
        public Int32 Cost { get; set; }
        public bool IsInStoke { get; set; }


        // Совсем не принципиально будет ли объект иммутабельным или нет, поэтому используем две формы.
        protected Commodity() { }
        protected Commodity(string name, Int32 cost, string brand, Color color, Int32 size, string style,
            bool isInStoke)
        {
            InternalId = Interlocked.Increment(ref _nextId);
            Brand = brand;
            Color = color;
            Size = size;
            Style = style;
            IsInStoke = isInStoke;
        }

        // Methods 
        // IComparable --> CompareTo, not done yet
        public virtual int CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }
            Commodity c = obj as Commodity; // double casting 
            if (c == null)
            {
                throw new Exception("error: CompareTo()");
            }
            
            return CompareTo(c);
        }
        
        // IComparer --> Compare √  
        public virtual int Compare(object obj1, object obj2)
        {
            return ((new CaseInsensitiveComparer()).Compare(obj1, obj2));
        }
        
        // IEnumerable --> GetEnumerator

        // public virtual IEnumerator GetEnumerator()
        // {
        //     
        // }
    }
}
