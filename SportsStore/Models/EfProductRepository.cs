using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class EfProductRepository:IProductRepository
    {

        //fields and props

        private AppDbContext _context;

        public EfProductRepository(AppDbContext context)
        {
            _context = context;
        }

        public IQueryable<Product> GetAllProducts()
        {
            return _context.Products;
        }
    }
}
