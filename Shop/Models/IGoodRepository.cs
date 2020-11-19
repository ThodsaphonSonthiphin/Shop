using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public interface IGoodRepository
    {
        public IEnumerable<Goods> Goods();
        public Goods GetGoodsByID(string id);
        public void SaveGoods(Goods goods);
    }
}
