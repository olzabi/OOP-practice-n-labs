using System;

namespace lab7_v9.Class
{
    public class Commodity
    {
        private string name;

        protected Commodity(string name)
        {
            this.name = name;
        }

        public void DisplayInfo()
        {
            Console.WriteLine(this.name);
        }
    }
}