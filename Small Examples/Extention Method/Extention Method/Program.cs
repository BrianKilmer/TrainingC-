using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extention_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product { ProductName = "widget", ProductPrice = 10.95 },
                new Product { ProductName = "thigie", ProductPrice = 5.65 },
                new Product { ProductName = "bam", ProductPrice = 100.07 }
            };

            foreach (Product p in products)
            {
                Console.WriteLine("Name: {0} Price: {1} Tax: {2}", p.ProductName, p.ProductPrice, p.CalculateTax());
            }
            Console.ReadLine();
        }
    }
}
