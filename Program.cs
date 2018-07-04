
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;

namespace Test
{
    class Program
    {
        private static int operandPoints = 0;//сколько хочет потратить
        public static Player player = new Player();
       
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в меню выбора создания персонажа! " +
                              "\n У вас есть 25 очков, которые вы можете распределить по умениям" +
                              "\n Нажмите любую клавишу чтобы продолжить...");
            Console.ReadKey();

            while (player.Points > 0)
            {
                Console.Clear();

                Console.WriteLine("Поинтов - {0}", player.Points);

                ShowPlayerStats();

                Console.WriteLine("Какую характеристику вы хотите изменить?");
                string subject = Console.ReadLine();

                Console.WriteLine(@"Что вы хотите сделать? +\-");
                string operation = Console.ReadLine();

                Console.WriteLine("Количество поинтов которые следует {0}", operation == "+" ? "прибавить" : "отнять");

                SetOperandPoints(Console.ReadLine(),player.Points);// потратить очков умений не больше, чам осталось

                switch (subject.ToLower())
                {
                    case "сила":
                        player.Strength = PointsToAbilities(operation,player.Strength);
                        break;

                    case "ловкость":
                        player.Agility = PointsToAbilities(operation,player.Agility);
                        break;

                    case "интеллект":
                        player.Intelligence = PointsToAbilities(operation,player.Intelligence);
                        break;
                    default : continue;
                }
            }

            Console.WriteLine("Вы распределили все очки. Введите возраст персонажа:");
            string ageRaw = string.Empty;int _age = 0;
            do
            {
                ageRaw = Console.ReadLine();
            } while (!int.TryParse(ageRaw, out _age));
            player.Age = _age;

            Console.Clear();

            ShowPlayerStats();
        }
        private static string SetProperty(string result, int property, char filler1 = '#', char filler2 = '_')
        {
            return result.PadLeft(property, filler1).PadRight(10, filler2);
        }

        private static void SetOperandPoints(string operandPointsRaw, int maxOperandPoints)
        {
            while (!int.TryParse(operandPointsRaw, out operandPoints) & operandPoints<=maxOperandPoints)
            {
                operandPointsRaw = Console.ReadLine();
            }

        }
        private static int PointsToAbilities(string operation,int stat)
        { 
            if (operation == "+")
            {
                if(player.Points - operandPoints >=0)
                {
                    player.Points -= operandPoints;
                }
                return operandPoints;
            }
            else
            {
                if (stat - operandPoints >= 0)
                {
                    player.Points += operandPoints;
                }
                return stat -= operandPoints;
            }
        }
        private static void ShowPlayerStats()
        {
            Console.WriteLine("Возраст - {0}\n Сила - [{1}] \n Ловкость - [{2}] \n Интеллект - [{3}]",
                                  player.Age, SetProperty(String.Empty, player.Strength),
                                  SetProperty(String.Empty, player.Agility),
                                  SetProperty(String.Empty, player.Intelligence));
        }

    }
}
