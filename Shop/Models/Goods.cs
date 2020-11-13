namespace Shop.Models
{
    public class Goods
    {
        public int GoodsID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public Order Order { get; set; }
    }
}