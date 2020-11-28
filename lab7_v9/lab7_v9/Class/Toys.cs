using System;

namespace lab7_v9.Class
{
    public class Toys : Commodity
    {
        private string country;

        public Toys(string name, string country) :
            base(name)
        {
            this.country = country;
        }

        public void DisplayCountry()
        {
            Console.WriteLine(this.country);
        }
    }
}