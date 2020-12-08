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
            Toy t1 = new Toy("Police Chibi", 345, "Gun Powder", Color.Aqua, 50, "small piece of coolity",
                true, 0.33);
            Toy t2 = new Toy("Beebop", 774,"Jp bla-bla inc.",
                Color.Beige, 164, "Original masterpiece chibi", false, 0.34);
            

            Console.WriteLine(t1.ToString());
            Console.WriteLine(t2.ToString());
        }
    }
}