using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreRepositoryAndUnitOfWorkPattern.Data.Models;
using NetCoreRepositoryAndUnitOfWorkPattern.Service.Services;

namespace NetCoreRepositoryAndUnitOfWorkPattern.Controllers
{
    public class CustomerController
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

            return await _customerService.AddCustomer(customer);
        }

        public ActionResult<List<Customer>> GetAllCustomers()
        {
            return _customerService.GetAllCustomer();
        }

        public async Task<ActionResult<Customer>> GetCustomerById()
        {
            return await _customerService.GetCustomerById(1);
        }
    }
}