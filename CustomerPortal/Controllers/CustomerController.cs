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

        public void ChangeCustomerName()
        {

        }

        public void ChangeCustomerShippingAddress()
        {

        }

        public void AddOrder()
        {

        }
        public void RemoveOrder()
        {

        }
    }
}
