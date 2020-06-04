using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NetCoreRepositoryAndUnitOfWorkPattern.Data.Models;
using NetCoreRepositoryAndUnitOfWorkPattern.Data.Repositories;

namespace NetCoreRepositoryAndUnitOfWorkPattern.Service.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Product GetMySpecialProduct()
        {
            return _productRepository.MyProductSpecificMethod();
        }

        public async Task<Product> GetProductById(int id)
        {
            return await _productRepository.GetAll().FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}