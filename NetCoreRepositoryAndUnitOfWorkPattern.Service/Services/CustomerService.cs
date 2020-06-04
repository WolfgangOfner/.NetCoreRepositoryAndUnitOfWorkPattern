using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NetCoreRepositoryAndUnitOfWorkPattern.Data.Models;
using NetCoreRepositoryAndUnitOfWorkPattern.Data.Repositories;

namespace NetCoreRepositoryAndUnitOfWorkPattern.Service.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly IRepository<Customer> _customerRepository;

        public CustomerService(IRepository<Customer> customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public List<Customer> GetAllCustomer()
        {
            return _customerRepository.GetAll().ToList();
        }

        public async Task<Customer> GetCustomerById(int id)
        {
            return await _customerRepository.GetAll().FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Customer> AddCustomer(Customer newCustomer)
        {
            return await _customerRepository.AddAsync(newCustomer);
        }
    }
}