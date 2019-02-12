using CustomerPortal.Controllers;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerPortal.Data;

namespace CustomerPortal.Tests
{
    public class OnTheCustomerController
    {
        private CustomerController _controller;
        private Mock<CustomerDbContext> _dbContext;

        [SetUp]
        protected void Setup()
        {
            _dbContext = new Mock<CustomerDbContext>();
            _controller = new CustomerController(_dbContext.Object);
        }
    }
}
