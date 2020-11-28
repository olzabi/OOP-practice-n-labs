using System;
using lab7_v9.Class;

namespace lab7_v9
{
    class Program
    {
        static void Main(string[] args)
        {
            Toys toy = new Toys("HelloKitty", "USA");
            toy.DisplayInfo();
            toy.DisplayCountry();}
    }
}