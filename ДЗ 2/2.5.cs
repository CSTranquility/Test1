using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Vector
    {
        public int X;
        public int Y;
        public Vector(int x, int y)
        {
            X = x;
            Y = y;
        }
        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector (v1.X + v2.X, v1.Y + v2.Y);
        }
        public static Vector operator *(Vector v, int multiplier)
        {
            return new Vector(v.X*multiplier,v.Y*multiplier);
        }
    }
}



