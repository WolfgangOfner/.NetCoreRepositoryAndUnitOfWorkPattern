using System.Threading.Tasks;
using NetCoreRepositoryAndUnitOfWorkPattern.Data.Models;

namespace NetCoreRepositoryAndUnitOfWorkPattern.Service.Services
{
    public interface IProductService
    {
        Task<Product> AddProductAsync(Product product);

        Task<Product> GetProductByIdAsync(int id);
    }
}