using System;
using System.Collections.Generic;
using lab8_v9.Class;

namespace lab8_v9
{
    /*
     * 1. Toy, Product, Commodity
     * 2. Constructor, methods
     * 3. Commodity --> virtual method
     * 4. Use VM in Product and Toy
     */
    class Program
    {
        static void Main(string[] args)
        {
            /* Toy display & constructor 
             *  name --> string
             *  cost --> decimal
             * country --> string
             * shop_name --> string
             */
            Toy t1 = new Toy("Wii", 5333, "USA", "Some Shop Name");
            Toy t2 = new Toy("Weee", 543, "Germany", "Plup Plop");
            t1.Display();
            t2.Display();

            Console.WriteLine(t1 + t2);
            
            /*
             * PRODUCT DISPLAY and CONSTRUCTOR BELOW
             * name --> string,
             * cost --> decimal,
             * shop_name --> string ,
             * expiration_date --> DataTime 
            */
            Product pr1 = new Product("pr1", 6666, "JP inc.", DateTime.Today);
            Product pr2 = new Product("pr2", 12345, "WaiWai", DateTime.Now);
            pr1.Display();
            
            Console.WriteLine(pr1 + pr2);




        }
    }
}