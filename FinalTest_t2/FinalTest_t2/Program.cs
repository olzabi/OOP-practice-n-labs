using System;
using System.Collections.Generic;
using System.Linq;

namespace FinalTest_t2
{
    /*
     9. Product:
        id,                
        Найменування,      
        UPC,               
        Виробник,          
        Ціна,              
        Термін зберігання, 
        Кількість.         
        
        Output:
        a) список товарів для заданого найменування;                                   
        b) список товарів для заданого найменування, ціна яких становить менше задану; 
        c) список товарів, термін зберігання яких більше заданого                      
        
        
        
        ean13 algorithm
        1. sum up even, sum up odd 
        ex. 
        **************************************
        | 13 12 11 10 9 8 7 6 5 4 3 2 1      | <--- digit position
        |                                    |
        | 3  0  5  5  6 4 0 0 7 1 5 3        | <--- 3d - country, 4d - manuf., 5d product code, 1d -> K
        | 3  +  5  +  6 + 0 + 7 + 5 = 26     | <--- odds
        |    0  +  5  + 4 + 0 + 1 + 3 = 13   | <--- even
        **************************************
        2. even * 3 + odd = res
        3. res %= 10 
        4. (10 - res) % 10 = K (1st position)
     */
    
    class Program
    {
        
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();


            Product p1 = new Product("Furniture", 383, new DateTime(2020, 10, 21), 450, 5, 3442,
                51519);
            
            Product p2 = new Product("Furniture", 401, new DateTime(2020, 12, 1), 760, 5, 8993,
                    40478);
            
            Product p3 = new Product("Accessory", 600, new DateTime(2021, 3, 21), 531, 5, 4114,
                92441);

            products.Add(p1);
            products.Add(p2);
            products.Add(p3);

            //
            var a = products.Where(p => p.Name == "Furniture").OrderBy(p => p.Name);
            var b = products.Where(p => p.Name == "Accessory").OrderBy(p => p.Cost < 400);
            var c = products.Where(p => p.Expiration.Date < new DateTime(2020, 11, 20)).OrderBy(p => p.Expiration);
            
            Console.WriteLine("OUTPUT A");
            foreach (var p in a)
            {
                Console.WriteLine("Name: {0} \nPrice: {1}, Expiration: {2}, UPC: {3}",
                    p.Name, p.Cost, p.Expiration.ToShortDateString(), p.Upc);
            }
            
            Console.WriteLine("OUTPUT B");
            foreach (var p in b)
            {
                Console.WriteLine("Name: {0} \nPrice: {1}, Expiration: {2}, UPC: {3}",
                    p.Name, p.Cost, p.Expiration.ToShortDateString(), p.Upc);
            }
            
            Console.WriteLine("OUTPUT C");
            foreach (var p in c)
            {
                Console.WriteLine("Name: {0} \nPrice: {1}, Expiration: {2}, UPC: {3}", 
                    p.Name, p.Cost, p.Expiration.ToShortDateString(), p.Upc);
            }
        }
    }
}