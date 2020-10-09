using System.Collections.Generic;
using System.Threading.Tasks;
using NetCoreRepositoryAndUnitOfWorkPattern.Data.Models;

namespace NetCoreRepositoryAndUnitOfWorkPattern.Data.Repositories
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        Task<Customer> GetCustomerByIdAsync(int id);

        Task<List<Customer>> GetAllCustomersAsync();
    }
}