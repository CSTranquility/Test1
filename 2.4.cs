using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ConsoleApp1
{

    class Player
    {
        public Health Health;
        public Map Map;
        public Vector2 Position;

        public Player(Map map)
        {
            Health = new Health();
            Position = new Vector2();
            Map = map;
        }

        public void Update()
        {
            if (Position.X < Map.Width)
            {
                Position.X++;
                if (Map.GetCell(Position.X, Position.Y) == '#')
                {
                    Health.ApplyDamage(10);
                }
            }
        }
    }
    struct Vector2
    {
        public int X, Y;       
    }

    class Health
    {
        public float Value;

        public bool IsAlive
        {
            get
            {
                return Value > 0;
            }
        }

        public void ApplyDamage(float damage)
        {
            Value -= damage;
        }
    }

    class Map
    {
        public char[,] Cells;

        public char GetCell(int x, int y)
        {
            return Cells[x, y];
        }

        public int Width
        {
            get
            {
                return Cells.GetLength(0);
            }
        }

        public int Height
        {
            get
            {
                return Cells.GetLength(1);
            }
        }
    }
}



