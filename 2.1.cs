using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ConsoleApp1
{
    class Stack
        {
            private int[] _data = new int[1];
            private int _top = -1;
            private readonly int MIN_VALUE = 1;
            private readonly int MAX_VALUE = 20;

            public bool IsEmpty()
            {
                return _top < 0;
            }
            public bool HasSpace()
            {
                return _top < _data.Length - 1;
            }
            public int GetLast()
            {
            if (_data.Any())
                return _data.Last();
            throw new NullReferenceException();
            }
            public void AddElement()
            {
            if (!HasSpace())
            {
                Expand();
            }
            _data[++_top] = new Random().Next(MIN_VALUE, MAX_VALUE);
        }
            private void Expand()
            {
                var old = _data;
                _data = new int[_data.Length * 2];
                Array.Copy(old, _data, old.Length);
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Stack pancakes = new Stack();

                while (true)
                {
                    Console.WriteLine("Что вы хотите?");
                    string command = Console.ReadLine();
                    switch (command)
                    {
                        case "Скушать":
                            if (!pancakes.IsEmpty())
                            {
                                Console.WriteLine($"В блинчике {pancakes.GetLast()} калорий");//бесконечные блины при непустом массиве
                            }
                            else
                            {
                                Console.WriteLine("Сначала надо испечь блинчик!");
                            }
                            break;
                        case "Испечь":
                            {                           
                                pancakes.AddElement();
                                Console.WriteLine($"Вы испекли блинчик с {pancakes.GetLast()} калориями");
                            }
                            break;
                        default:
                            Console.WriteLine("Попробуйте еще раз");
                            break;
                    }
                }
            }
        }
}



