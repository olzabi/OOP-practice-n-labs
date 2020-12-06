using System;

namespace lab8_v9.Class
{
    public class Product : Commodity
    {
        protected DateTime ExpirationDate;
        
        // Product constructor with inheritance Commodity
        public Product(string name, decimal cost, string shopName, DateTime expirationDate) :
            base(name, cost, shopName) // Commodity 
        {
            this.ExpirationDate = expirationDate;
        }

        // method returns a line with a given variable
        // type DataTime, formatted to show a short date "dd.mm.yyyy" 
        public override void Display()
        {  
            Console.WriteLine("Commodity name: {0}", Name );
            Console.WriteLine("Commodity cost: {0}", Cost );
            Console.WriteLine("exp. date: {0}", ExpirationDate.ToString("d"));
        }
    }
}