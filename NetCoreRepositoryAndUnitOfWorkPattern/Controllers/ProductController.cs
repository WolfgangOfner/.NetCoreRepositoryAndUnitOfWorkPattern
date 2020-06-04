using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreRepositoryAndUnitOfWorkPattern.Data.Models;
using NetCoreRepositoryAndUnitOfWorkPattern.Service.Services;

namespace NetCoreRepositoryAndUnitOfWorkPattern.Controllers
{
    public class ProductController
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<ActionResult<Product>> GetProductById()
        {
            return await _productService.GetProductById(1);
        }

        public ActionResult<Product> GetSpecialProduct()
        {
            return _productService.GetMySpecialProduct();
        }
    }
}