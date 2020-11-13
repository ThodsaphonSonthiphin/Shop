using System;
using System.Collections.Generic;

namespace Shop.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public DateTime OrderDateTime { get; set; }
        public Customer Customer { get; set; }
        public List<Goods> Goods { get; set; }
    }
}