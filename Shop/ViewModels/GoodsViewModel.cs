using Shop.Models;

namespace Shop.ViewModels
{
    public class GoodsViewModel
    {
        public GoodsViewModel(Goods goods)
        {
            this.Name = goods.Name;
            this.Category = goods.Category;
        }
        public byte[] ImageBytes { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
       
    }
}