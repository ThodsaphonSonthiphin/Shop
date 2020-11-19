using System.Collections.Generic;
using System.Linq;

namespace Shop.Models
{
    public class MockGoodRepository:IGoodRepository
    {
        public MockGoodRepository()
        {
            this.MockGoods = new List<Goods>()
            {
                new Goods {Name = "Iphone 6", Category = "Phone",GoodsID = 1},
                new Goods {Name = "Iphone 7", Category = "Phone", GoodsID = 2},
                new Goods {Name = "Iphone 8", Category = "Phone",GoodsID = 3},
                new Goods {Name = "Lenovo-N", Category = "NoteBook", GoodsID = 4},
                new Goods {Name = "Lenovo-PC", Category = "PC",GoodsID = 5}
            };
        }
        public List<Goods> MockGoods { get; set; }
        public IEnumerable<Goods> Goods()
        {
            return MockGoods;
        }

        public Goods GetGoodsByID(string id)
        {
            var myID = int.Parse(id);
            return MockGoods.Where(g => g.GoodsID == myID).FirstOrDefault();
        }

        public void SaveGoods(Goods goods)
        {
            MockGoods.Add(goods);
        }

        
    }
}