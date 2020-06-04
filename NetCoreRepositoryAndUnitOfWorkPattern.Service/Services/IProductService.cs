using System.Threading.Tasks;
using NetCoreRepositoryAndUnitOfWorkPattern.Data.Models;

namespace NetCoreRepositoryAndUnitOfWorkPattern.Service.Services
{
    public interface IProductService
    {
        Product GetMySpecialProduct();
        Task<Product> GetProductById(int id);
    }
}