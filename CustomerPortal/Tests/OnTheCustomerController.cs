using CustomerPortal.Controllers;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerPortal.Data;
using CustomerPortal.Models;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace CustomerPortal.Tests
{
    public class OnTheCustomerController
    {
        protected CustomerController controller;
        protected CustomerDbContext dbContext;
        protected List<Customer> customerList;

        [SetUp]
        protected virtual void SetUp()
        {
            customerList = new List<Customer>()
            {
                new Customer()
                {
                    Id = 1,
                    FirstName = "Bob",
                    MiddleName = "Clarence",
                    LastName = "Boberson",
                    Orders = new List<Order>()
                    {
                        new Order()
                        {
                            Id = 1,
                            CustomerId = 1
                        }
                    },
                    Contacts = new List<CustomerContact>()
                    {
                        new CustomerContact()
                        {
                            Id = 1,
                            CustomerId = 1,
                            Type = "Phone",
                            Value = "1800 Bobs Phone"
                        }
                    },
                    ShippingAddress = new CustomerAddress()
                    {
                        Id = 1,
                        CustomerId = 1,
                        Line1 = "123 Hwy",
                        Line2 = null,
                        City = "Dallas",
                        State = "TX",
                        Country = "USA",
                    }
                },
                new Customer()
                {
                    Id = 2,
                    FirstName = "Bob",
                    MiddleName = "Clarence",
                    LastName = "Boberson",
                    Orders = new List<Order>()
                    {
                        new Order()
                        {
                            Id = 2,
                            CustomerId = 2
                        }
                    },
                    Contacts = new List<CustomerContact>()
                    {
                        new CustomerContact()
                        {
                            Id = 2,
                            CustomerId = 2,
                            Type = "Phone",
                            Value = "1800 Bobs Phone"
                        }
                    },
                    ShippingAddress = new CustomerAddress()
                    {
                        Id = 2,
                        CustomerId = 2,
                        Line1 = "123 Hwy",
                        Line2 = null,
                        City = "Dallas",
                        State = "TX",
                        Country = "USA",
                    }
                },
                new Customer()
                {
                    Id = 3,
                    FirstName = "Bob",
                    MiddleName = "Clarence",
                    LastName = "Boberson",
                    Orders = new List<Order>()
                    {
                        new Order()
                        {
                            Id = 3,
                            CustomerId = 3
                        }
                    },
                    Contacts = new List<CustomerContact>()
                    {
                        new CustomerContact()
                        {
                            Id = 3,
                            CustomerId = 3,
                            Type = "Phone",
                            Value = "1800 Bobs Phone"
                        }
                    },
                    ShippingAddress = new CustomerAddress()
                    {
                        Id = 3,
                        CustomerId = 3,
                        Line1 = "123 Hwy",
                        Line2 = null,
                        City = "Dallas",
                        State = "TX",
                        Country = "USA",
                    }
                }
            };
            
            var options = new DbContextOptionsBuilder<DbContext>()
                  .UseInMemoryDatabase(Guid.NewGuid().ToString())
                  .Options;

            dbContext = new CustomerDbContext(options);
            dbContext.Customers.AddRange(customerList);
            dbContext.SaveChanges();

            controller = new CustomerController(dbContext);
        }
    }
}
