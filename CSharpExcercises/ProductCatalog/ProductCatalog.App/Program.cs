using System;
using ProductCatalog.Library;

namespace ProductCatalog.App
{
    public class Program
    {
        static void Main(string[] args)
        {
           var product = new Product();
           product.Color = "red";
           product.Name = "Bicycle";
           product.Price = 200;

           product.ApplyDiscount(8);

           Console.WriteLine($"price after discount: ${product.Price}");
        }

    }
}
