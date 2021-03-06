﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerPortal.Data.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public List<Order> Orders { get; set; }
        public List<CustomerContact> Contacts { get; set; }
        public CustomerAddress ShippingAddress { get; set; }

    }
}
