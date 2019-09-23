using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Store.Models;

namespace Store.Services
{
    public class ProductService
    {
        public List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Milk",
                    Price = 10
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Chocolate",
                    Price = 5
                }
            };
        }
    }
}
