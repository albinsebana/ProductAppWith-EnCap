using ProductAppWithEncapsulation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAppWithEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product
            {
                Id = 1,
                Name = "Tomato",
                Price = 100.0m,
                DiscountPercentage = 10.0
            };

            Product product2 = new Product
            {
                Id = 2,
                Name = "Horlicks",
                Price = 50.0m,
                DiscountPercentage = 15.0
            };

            Console.WriteLine("Product 1 Details:");
            Console.WriteLine($"ID: {product1.Id}");
            Console.WriteLine($"Name: {product1.Name}");
            Console.WriteLine($"Price: Rs {product1.Price}");
            Console.WriteLine($"Discount Percentage: {product1.DiscountPercentage}%");
            Console.WriteLine($"Price After Discount: Rs{product1.CalculateCostAfterDiscount()}");

            Console.WriteLine();

            Console.WriteLine("Product 2 Details:");
            Console.WriteLine($"ID: {product2.Id}");
            Console.WriteLine($"Name: {product2.Name}");
            Console.WriteLine($"Price: Rs {product2.Price}");
            Console.WriteLine($"Discount Percentage: {product2.DiscountPercentage}%");
            Console.WriteLine($"Price: Rs  {product2.CalculateCostAfterDiscount()}");
        }
    }
}
   