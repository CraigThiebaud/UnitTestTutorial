using CustomerPortal.Models;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerPortal.Tests
{
    public class WhenGettingCustomer : OnTheCustomerController
    {
        private Customer customer;
        private int customerId;

        [SetUp]
        protected override void SetUp()
        {
            base.SetUp();
            customerId = 1;
        }

        void Because()
        {
            customer = controller.GetCustomerById(customerId);
        }

        [Test]
        public void ShouldReturnCustomer()
        {
            Because();
            Assert.IsNotNull(customer);
            Assert.IsInstanceOf<Customer>(customer);
        }

        [Test]
        public void ShouldReturnExpectedCustomer()
        {
            Because();
            Assert.IsNotNull(customer);
            Assert.AreEqual(customerId, customer.Id);

            customerId = 2;
            Because();
            Assert.IsNotNull(customer);
            Assert.AreEqual(customerId, customer.Id);

            customerId = 3;
            Because();
            Assert.IsNotNull(customer);
            Assert.AreEqual(customerId, customer.Id);
        }
    }
}
