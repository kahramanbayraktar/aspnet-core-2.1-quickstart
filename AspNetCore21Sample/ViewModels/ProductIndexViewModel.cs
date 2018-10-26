using AspNetCore21Sample.Models;
using System.Collections.Generic;

namespace AspNetCore21Sample.ViewModels
{
    public class ProductIndexViewModel
    {
        public string Title { get; set; }

        public List<Product> Products { get; set; }
    }
}
