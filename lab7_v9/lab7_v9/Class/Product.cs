using System;

namespace lab7_v9.Class
{
    public class Product: Commodity
    {
        private int price;

        protected Product(string name, int price) :
            base(name)
        {
            this.price = price;
        }

        public void DisplayPrice()
        {
            Console.WriteLine(this.price);
        }
    }
}