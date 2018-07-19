using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class WendingMachine  //заключает состояние баланса и делегирует команды пользователя другим классам
    {
        public int Balance;
        public GoodRepository Goods;

        public WendingMachine(int balance, GoodRepository goods)
        {
            Balance = balance;
            Goods = goods;
        }
        public int ClearBalance(int change)
        {
            Balance = 0;
            return change;
        }
        public void OrderValidation(Order order)
        {
            if (order==null) throw new ArgumentNullException("Order doesn't exist!");//проверка введенного количества товара
            order.CheckCount();
            if (Balance < order.GetTotalPrice()) throw new InvalidOperationException("Not enough money");// если недостаточно средств
            Balance -= order.GetTotalPrice();
              
        }

        public void BuyGood(Good good, int count)
        {
            
            if (good!=null && good.Count!=0)
            {

            }
        }

        public Good[] GetProductList()
        {
            return Goods.GetAvailableGoods();
        }
        
    }
}
