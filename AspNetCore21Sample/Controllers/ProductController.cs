using AspNetCore21Sample.Models;
using AspNetCore21Sample.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AspNetCore21Sample.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult Index()
        {
            var products = _productRepository.GetAllProducts().ToList();

            var model = new ProductIndexViewModel
            {
                Title = "All Products",
                Products = products
            };

            return View(model);
        }
    }
}