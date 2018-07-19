using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class GoodRepository// решает задачи проверки наличия и выдачи товара
    {
        public Good[] Goods;//хранит товар

        public GoodRepository(Good[] goods)
        {
            Goods = goods;
        }
        public bool ContainsGood(Good good)
        {
            return Goods.Contains(good);
        }

        public Good[] GetAvailableGoods()
        {
            List<Good> result = new List<Good>();

            foreach (Good good in Goods)
            {
                if (good != null && good.Count > 0)
                {
                    result.Add(good);
                }
            }
            return result.ToArray();
        }

        public Good GetProduct(string name)
        {
            foreach (Good good in Goods)
            {
                if (good.Name == name)
                {
                    return good;
                }
            }
            return null;
        }
       
    }
}
