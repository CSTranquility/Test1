using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class WendingMachineGUI// общение с пользователем
    {
        public WendingMachine Machine;

        public WendingMachineGUI(WendingMachine machine)
        {
            Machine = machine;
        }

        public void Update()
        {
            Console.Clear();
            Console.WriteLine($"Balance - {Machine.Balance}");
            Console.WriteLine();

            Console.WriteLine("Write command...");

            string command = Console.ReadLine();
            switch (command)
            {
                case "help":
                    Console.WriteLine("list\n " +
                                     "order \n");
                    break;
                case "list":
                    foreach (Good good in Machine.GetProductList())
                    {
                        Console.WriteLine($">{good.Name} [{good.Count}]");
                    }
                    break;
                case "order":
                    Machine.Balance = SetMachineBalance();
                    Console.WriteLine("Enter product name");
                    string productName = NameVerification(Console.ReadLine());
                    Console.WriteLine("Enter amount");
                    int count = CountVerification(Console.ReadLine());

                    Order order = new Order(Machine.Goods.GetProduct(productName), count);
                    Machine.OrderValidation(order);
                    Console.WriteLine($"Total price - {order.GetTotalPrice()}");                    
                    
                    Console.WriteLine($"Change is {Machine.ClearBalance(Machine.Balance)}");
                    break;
                default:
                    Console.WriteLine("Enter valid command");
                    break;
            }
            Console.WriteLine("Press any button");
            Console.ReadKey();
        }
        private string NameVerification(string name)
        {
            while (!Machine.Goods.ContainsGood(Machine.Goods.GetProduct(name)))
            {
                Console.WriteLine("Enter valid product name");
                name = Console.ReadLine();
            }
            return name;     
        }
        private int CountVerification(string count)
        {
            int result = 0;
            while(!Int32.TryParse(count, out result))
            {
                Console.WriteLine("Enter correct count");
                count = Console.ReadLine();
            }
            return result;
        }
        private int SetMachineBalance()//лапша с сахаром
        {
            Console.WriteLine("Make a payment");
            return CountVerification(Console.ReadLine());
        }

    }
}
