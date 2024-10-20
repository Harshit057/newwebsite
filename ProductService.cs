using ProductAZ.Models;
using System.Collections.Generic;

namespace ProductAZ.Services
{
    public class ProductService
    {
        public List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "Product 1",
                    Description = "This is a great product.",
                    Price = 19.99m,
                    ImageUrl = "/images/product1.jpg"
                },
                new Product
                {
                    Id = 2,
                    Name = "Product 2",
                    Description = "This is an awesome product.",
                    Price = 29.99m,
                    ImageUrl = "/images/product2.jpg"
                },
                new Product
                {
                    Id = 3,
                    Name = "Product 3",
                    Description = "You will love this product.",
                    Price = 39.99m,
                    ImageUrl = "/images/product3.jpg"
                },
                new Product
                {
                    Id = 4,
                    Name = "Product 4",
                    Description = "Don't miss out on this product.",
                    Price = 49.99m,
                    ImageUrl = "/images/product4.jpg"
                }
            };
        }
    }
}
