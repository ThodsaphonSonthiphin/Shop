using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Models
{
    public class Goods
    {
        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GoodsID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string ImagePath { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}