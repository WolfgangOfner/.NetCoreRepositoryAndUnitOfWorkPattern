using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NetCoreRepositoryAndUnitOfWorkPattern.Data.Models;

namespace NetCoreRepositoryAndUnitOfWorkPattern.Data.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(RepositoryPatternDemoContext repositoryPatternDemoContext) : base(repositoryPatternDemoContext)
        {
        }

        public Task<Product> GetProductByIdAsync(int id)
        {
            return GetAll().FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}