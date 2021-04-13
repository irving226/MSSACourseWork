using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IQueryable<Product> GetAllProducts()
        {

            Product[] products = new Product[3];
            products[0] = new Product
            {
                Name = "Football",
                Price = 25
            };

            products[1] = new Product
            {
                Name = "Surf Board",
                Price = 179
            };

            products[2] = new Product
            {
                Name = "Running Shoes",
                Price = 95
            };

            return products.AsQueryable<Product>();

        }   //end GetAllProducts()
    }
}
