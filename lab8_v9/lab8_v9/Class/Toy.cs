using System;
using lab8_v9.Class;

namespace lab8_v9.Class
{
    public class Toy : Commodity
    {

        private string ManufacturerCountry;
        
        // Toy constructor with inheritance Commodity
        public Toy(string name, int cost, string manufacturerCountry, string shopName) :
            base(name, cost, shopName) // Commodity
        {
            this.ManufacturerCountry = manufacturerCountry;
        }
        
        // method returns a console line with info.
        public override void Display()
        {
            Console.WriteLine($"{ManufacturerCountry}, {Name}, {Cost}");  
        } 

    }
}