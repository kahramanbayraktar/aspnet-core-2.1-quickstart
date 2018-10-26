using System.Collections.Generic;
using System.Linq;

namespace AspNetCore21Sample.Models
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _context.Products;
        }

        public Product GetProductById(int id)
        {
            return _context.Products.SingleOrDefault(x => x.ProductId == id);
        }
    }
}
