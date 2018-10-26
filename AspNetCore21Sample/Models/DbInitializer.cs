using System.Collections.Generic;
using System.Linq;

namespace AspNetCore21Sample.Models
{
    public class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new List<Product>
                    {
                        new Product
                        {
                            Name = "Product 1", Price = 199.95M, ShortDescription = "Product 1", LongDescription = "Lorem ipsum...", ImageUrl = "", ImageThumbnailUrl = ""
                        },
                        new Product
                        {
                            Name = "Product 2", Price = 299.95M, ShortDescription = "Product 2", LongDescription = "Lorem ipsum...", ImageUrl = "", ImageThumbnailUrl = ""
                        },
                        new Product
                        { 
                            Name = "Product 3", Price = 399.95M, ShortDescription = "Product 3", LongDescription = "Lorem ipsum...", ImageUrl = "", ImageThumbnailUrl = ""
                        }
                    });
            }

            context.SaveChanges();
        }
    }
}
