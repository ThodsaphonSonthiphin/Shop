using System;
using System.Collections.Generic;

namespace Shop.Models
{
    public class Customer
    {
        public string Name { get; set; }
        public string lastname { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Provine { get; set; }
        public string City { get; set; }
        public List<Order> Order { get; set; }
    }

    public class Order
    {
        private DateTime OrderDateTime { get; set; }
    }
}