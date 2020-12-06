using System;
using System.Collections.Generic;
using System.Linq;

namespace lab8_v9.Class
{
    public abstract class Commodity
    {
        private string _name { get; set; }
        private decimal _cost { get; set; }
        private string _shopName { get; set; }

        
        public string Name => _name;
        public decimal Cost => _cost;
        public string ShopName => _shopName;
        

        public Commodity(string name, decimal cost, string shopName)
        {
            _name = name;
            _cost = cost;
            _shopName = shopName;
        }
        
        public static decimal operator +(Commodity c1, Commodity c2)
        {
            var cost = c1.Cost + c2.Cost;
            return cost;
        }

        public virtual void Display()
        {
            Console.WriteLine($"{Name}, {Cost}, {ShopName}");
        }
    }
}