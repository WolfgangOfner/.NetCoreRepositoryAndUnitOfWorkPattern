using System.Threading.Tasks;
using NetCoreRepositoryAndUnitOfWorkPattern.Data.Models;

namespace NetCoreRepositoryAndUnitOfWorkPattern.Data.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<Product> GetProductByIdAsync(int id);
    }
}