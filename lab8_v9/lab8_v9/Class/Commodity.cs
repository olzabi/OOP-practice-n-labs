using System;

namespace lab8_v9.Class
{
    public abstract class Commodity
    {
        protected string Name { get; set; }
        protected decimal Cost { get; set; }
        protected string ShopName { get; set; }

        protected Commodity(string name, decimal cost, string shopName)
        {
            Name = name;
            Cost = cost;
            ShopName = shopName;
        }


        public virtual void Display()
        {
            Console.WriteLine(Name, Cost, ShopName);
        }
    }
}