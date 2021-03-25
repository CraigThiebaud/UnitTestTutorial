using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CustomerPortal.Data;
using CustomerPortal.Models;

namespace CustomerPortal.Controllers
{
    public class CustomerController : Controller
    {
        private CustomerDbContext customerDbContext;

        public CustomerController(CustomerDbContext dbContext)
        {
            customerDbContext = dbContext;
        }

        public void AddCustomer()
        {

        }

        public CustomerRequest GetCustomerById(int id)
        {
            var customer = customerDbContext.Customers
                .Where(c => c.Id == id).First();
            
            return customer;
        }

        public void UpdateCustomerById(CustomerRequest)
        {
            var customer = customerDbContext.Customers
        }

        public void AddOrderByCustomerId()
        {

        }
        public void RemoveOrderByCustomerAndOrderId()
        {

        }
    }
}
