using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreRepositoryAndUnitOfWorkPattern.Data.Models;
using NetCoreRepositoryAndUnitOfWorkPattern.Service.Services;

namespace NetCoreRepositoryAndUnitOfWorkPattern.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public async Task<ActionResult<Customer>> CreateCustomer()
        {
            var customer = new Customer
            {
                Age = 30,
                FirstName = "Wolfgang",
                LastName = "Ofner"
            };

            return await _customerService.AddCustomerAsync(customer);
        }

        public async Task<ActionResult<List<Customer>>> GetAllCustomers()
        {
            return await _customerService.GetAllCustomersAsync();
        }

        public async Task<ActionResult<Customer>> GetCustomerById()
        {
            return await _customerService.GetCustomerByIdAsync(1);
        }
    }
}