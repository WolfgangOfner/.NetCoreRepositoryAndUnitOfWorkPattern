using System.Collections.Generic;
using System.Threading.Tasks;
using NetCoreRepositoryAndUnitOfWorkPattern.Data.Models;

namespace NetCoreRepositoryAndUnitOfWorkPattern.Service.Services
{
    public interface ICustomerService
    {
        Task<List<Customer>> GetAllCustomersAsync();
        Task<Customer> GetCustomerByIdAsync(int id);
        Task<Customer> AddCustomerAsync(Customer newCustomer);
    }
}