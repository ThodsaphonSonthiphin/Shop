using System;
using System.Collections.Generic;

namespace Shop.Models
{
    public class Order
    {
        #region Entity Property

        public int OrderID { get; set; }
        public DateTime OrderDateTime { get; set; }

        #endregion

        public Customer Customer { get; set; }
        public int Customerid { get; set; }


        public List<OrderDetail> OrderDetail { get; set; }
    }

    public class OrderDetail
    {
        public int GoodQuantity { get; set; }


        public int OrderID { get; set; }
        public int GoodID { get; set; }

        public Order Order { get; set; }

        public Goods Goods { get; set; }
    }
}