using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Good
    {
        //члены класса
        public int Price;//поля
        public string Name;
        public int Count;

        public Good(int price, string name, int count)
        {
            Price = price;
            Name = name;
            Count = count;
        }
        public bool IsAvailable()
        {
            return Count > 0;
        }
    }
}
