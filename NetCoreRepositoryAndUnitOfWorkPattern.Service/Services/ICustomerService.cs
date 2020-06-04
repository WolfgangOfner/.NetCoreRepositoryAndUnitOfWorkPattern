using System.Collections.Generic;
using System.Threading.Tasks;
using NetCoreRepositoryAndUnitOfWorkPattern.Data.Models;

namespace NetCoreRepositoryAndUnitOfWorkPattern.Service.Services
{
    public interface ICustomerService
    {
        List<Customer> GetAllCustomer();
        Task<Customer> GetCustomerById(int id);
        Task<Customer> AddCustomer(Customer newCustomer);
    }
}