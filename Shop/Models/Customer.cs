﻿using System.Collections.Generic;
using System.ComponentModel;

namespace Shop.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string lastname { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Provine { get; set; }
        public string City { get; set; }
        public List<Order> Order { get; set; }
    }
}