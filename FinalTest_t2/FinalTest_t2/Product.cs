using System;
using System.Threading;

namespace FinalTest_t2
{
    public class Product 
    {
        // id field
        private static int NextId;
        private int Id { get; set; }
        
        
        // product fields
        private int ProductCountryCode { get; set; }
        private string ProductName { get; set; }
        private DateTime ExpirationDate { get; set; }
        private int Price { get; set; }
        private int Quantity { get; set; }

        
        public int Country => ProductCountryCode;
        public string Name => ProductName;
        public DateTime Expiration => ExpirationDate;
        public int Cost => Price;
        public int Quant => Quantity;
        
        
        // UPC 
        private int ManufacturerCode { get; set; }
        
        private int ProductCode { get; set; }
        private string UpcCode => $"{ProductCountryCode}{ManufacturerCode}{ProductCode}" ;
        public string Upc => UpcCode + Ean13(UpcCode).ToString();
        
        
        // Constructor
        public Product(string name, int country,DateTime expiration, int price, int quantity, int manufacturerCode,
            int productCode)
        {
            Id = Interlocked.Increment(ref NextId);

            ProductName = name;
            ProductCountryCode = country;
            ExpirationDate = expiration;
            Price = price;
            Quantity = quantity;
            
            ProductCode = productCode;
            ManufacturerCode = manufacturerCode;
        }

        
        // Methods    
        static int Ean13(string barcode) 
        {
            int counter = 0;
            int sum = 0;
            
            
            if (barcode.Length != 12 & barcode.Length != 8)
                throw new Exception("Bad barcode length");

            for (int j = barcode.Length - 2; j > -1; j--)
            {
                counter += 1;
                if (counter % 2 == 0) {
                    sum += int.Parse(barcode[j].ToString());
                } else {
                    sum += int.Parse(barcode[j].ToString()) * 3;
                }
            }
            sum = (10 - (sum % 10)) % 10;
            return sum;
        }
    }
}