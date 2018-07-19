using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Order// снимает товар(не очень логично, но т.к. все внутри автомата, то можно
    {
        public Good Good;
        public int Count;

        public Order(Good good, int count)
        {
            Good = good;
            Count = count;
        }
        public int GetTotalPrice()
        {
            return Good.Price * Count;
        }
  
        public void CheckCount()//проверка на наличие достаточного кол-ва товара
        {
            if (Good.Count >= Count)
                Good.Count -= Count;
            else
                throw new InvalidOperationException("Not enough goods");
        }
    }
}
