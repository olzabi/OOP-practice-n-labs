using System;
using System.Collections.Generic;
using System.Drawing;
using lab9_v9.Class;

namespace lab9_v9
{
    /*
     lab 9.1 --> Toy, product, commodity 
     create interface for one of them
     use 2 abstract methods in inheritance classes
     
     lab 9.2 
     1) create an array of Commodity objects
     Use interface <IComparable> to compare goods by price in method CompareTo() --> √
     2) Use IComparer in classes to compare goods by price and size 
     3) Use interface <IEnumerable>. O/ goods list ordered by price 
     
     lab 11
     1) Use List<T>
     2) Use .Add to fill List<T> 
     */
    
    
    class Program
    {
        static void Main(string[] args)
        {
            Toy t1 = new Toy()
            {
                Brand = "Gun Powder",
                Color = Color.Aquamarine,
                Cost = 3455,
                InternalId = 0,
                IsInStoke = true,
                Name = "Police Chibi",
                Size = 50,
                Style = "small piece of coolity"
            };

            Console.WriteLine(t1.ToString());
        }
    }
}