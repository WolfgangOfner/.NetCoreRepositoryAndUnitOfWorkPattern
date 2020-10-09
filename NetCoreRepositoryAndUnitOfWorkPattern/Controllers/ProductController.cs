using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreRepositoryAndUnitOfWorkPattern.Data.Models;
using NetCoreRepositoryAndUnitOfWorkPattern.Service.Services;

namespace NetCoreRepositoryAndUnitOfWorkPattern.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<ActionResult<Product>> GetProductById()
        {
            return await _productService.GetProductByIdAsync(1);
        }

        public async Task<ActionResult<Product>> CreateProduct()
        {
            var product = new Product
            {
                Name = "Name",
                Description = "Desc",
                Price = 99.99m
            };

            return await _productService.AddProductAsync(product);
        }
    }
}