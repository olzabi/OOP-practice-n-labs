using System;
using lab8_v9.Class;

namespace lab8_v9.Class
{
    public class Toy : Commodity
    {

        private string _manufacturerCountry { get; set; }
        public string ManufacturerCountry => _manufacturerCountry;
        
        
        // Toy constructor with inheritance Commodity
        public Toy(string name, int cost, string manufacturerCountry, string shopName) :
            base(name, cost, shopName) // Commodity
        {
            _manufacturerCountry = manufacturerCountry;
        }
        

        // method returns a console line with info.
        public override void Display()
        {
            Console.WriteLine("Country creator: {0}", ManufacturerCountry);
            Console.WriteLine("Commodity name: {0}", Name);
            Console.WriteLine("Commodity cost: {0}", Cost);
        }
    }
}