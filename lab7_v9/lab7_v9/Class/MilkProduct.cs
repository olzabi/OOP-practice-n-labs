using System;

namespace lab7_v9.Class
{
    public class MilkProduct : Product
    {
        private int expirationDate;

        public MilkProduct(string name, int price, int expirationDate) :
            base(name, price)
        {
            this.expirationDate = expirationDate;
        }
        
        
        public void DisplayExpirationDate()
        {
            Console.WriteLine(this.expirationDate);
        }
    }
}