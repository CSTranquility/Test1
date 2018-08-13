using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        
        public static void Main()
        {
            Human h = new Human(100, 20);
            Random r = new Random();
            while(true)
            {
                h.TakeDamage(r.Next(10, 100));
                Thread.Sleep(100);
            }
        }
    }
    class Warrior
    {
        protected int _health;
        protected Warrior(int health)
        {
            _health = health;
        }
        protected void DeadMessage()
        {
            if (_health < 0)
                Console.WriteLine("Я умер");
        }
    }
    class Wombat:Warrior
    {
        private int _armor;

        public Wombat(int health,int armor):base(health)
        {
            _armor = armor;
        }
        public void TakeDamage(int damage)
        {
            _health -= damage - _armor;
            base.DeadMessage();
        }
    }

    class Human:Warrior
    {
        private int _agility;
        public Human(int health, int agility) : base(health)
        {
            _agility = agility;
        }
        public void TakeDamage(int damage)
        {
            _health -= damage / _agility;
            DeadMessage();
        }
    }
}



