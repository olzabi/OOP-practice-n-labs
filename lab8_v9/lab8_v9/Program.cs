using System;
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
            Toy toy = new Toy("OOO", 5333, "USA", "IDK");
            toy.Display();
            
            /*
             * PRODUCT DISPLAY and CONSTRUCTOR BELOW
             * name --> string,
             * cost --> decimal,
             * shop_name --> string ,
             * expiration_date --> DataTime 
            */
            Product product = new Product("name", 12345, "OOO", DateTime.Today);
            product.Display();
        }
    }
}