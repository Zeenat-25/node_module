using System.Collections.Generic;

namespace CARTApp
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public class ProductRepository
    {
        public static List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product { ID = 1, Name = "Laptop", Price = 50000 },
                new Product { ID = 2, Name = "Mobile", Price = 20000 },
                new Product { ID = 3, Name = "Headphones", Price = 2000 }
            };
        }
    }
}