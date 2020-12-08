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
            // array of objects
            Toy[] toys = new Toy[3]
            {
                new Toy("wasp", 345, "Gun Powder", Color.BlueViolet, 173, "Animal",
                    true, 0.33),
                new Toy("Dragon Ball", 345, "Gun Powder", Color.Salmon, 25, "Fantasy",
                    true, 0.33),
                new Toy("Glec", 345, "Gun Powder", Color.DodgerBlue, 73, "idk",
                    true, 0.33)
            };

            foreach (Toy toy in toys)
            {
                Console.WriteLine(toy.Name, toy.Cost);
            }
            
            List<Toy> arr = new List<Toy>(); // lab 11 --> List<T>

            Toy t1 = new Toy("Police Chibi", 345, "Gun Powder", Color.Aqua, 50, "small piece of coolity",
                true, 0.33);
            Toy t2 = new Toy("Beebop", 774,"Jp bla-bla inc.",
                Color.Beige, 164, "Original masterpiece chibi", false, 0.34);
            
            arr.Add(t1);
            arr.Add(t2);

            foreach (Toy value in arr)
            {
                Console.WriteLine(value);
            }
        }
    }
}