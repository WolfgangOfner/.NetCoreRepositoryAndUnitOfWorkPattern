using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NetCoreRepositoryAndUnitOfWorkPattern.Data.Models;

namespace NetCoreRepositoryAndUnitOfWorkPattern.Data.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(RepositoryPatternDemoContext repositoryPatternDemoContext) : base(repositoryPatternDemoContext)
        {
        }

        public async Task<Customer> GetCustomerByIdAsync(int id)
        {
            return await GetAll().FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Customer>> GetAllCustomersAsync()
        {
            return await GetAll().ToListAsync();
        }
    }
}