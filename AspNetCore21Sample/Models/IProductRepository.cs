using System.Collections.Generic;

namespace AspNetCore21Sample.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
        Product GetProductById(int id);
    }
}
