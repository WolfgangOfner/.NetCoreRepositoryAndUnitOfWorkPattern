using NetCoreRepositoryAndUnitOfWorkPattern.Data.Models;

namespace NetCoreRepositoryAndUnitOfWorkPattern.Data.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly RepositoryPatternDemoContext _repositoryPatternDemoContextContext;

        public ProductRepository(RepositoryPatternDemoContext repositoryPatternDemoContextContext) : base(repositoryPatternDemoContextContext)
        {
            _repositoryPatternDemoContextContext = repositoryPatternDemoContextContext;
        }

        public Product MyProductSpecificMethod()
        {
            // Get some amazing data from the database and then return it;
            // return _repositoryPatternDemoContextContext.GetAmazingData();

            return new Product
            {
                Name = "ProductName",
                Description = "Special Description",
                Price = 1234567m
            };
        }
    }
}