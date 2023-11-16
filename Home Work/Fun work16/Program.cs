using System;

namespace Fun_work16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double money = 0;
            double currentMoney = 0;
            

            while (input != "Start")
            {
                double moneyTransfer = double.Parse(input);
                if (moneyTransfer == 0.1 || moneyTransfer == 0.2 || moneyTransfer == 0.5 || moneyTransfer == 1 || moneyTransfer == 2)
                {
                    money += moneyTransfer;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {moneyTransfer}");
                }
                input = Console.ReadLine();
            }

            while (input != "End")
            {
                string product = Console.ReadLine();

                if (product == "Nuts")
                {
                    if (money >= 2.0)
                    {
                        currentMoney = money - 2.0;
                        Console.WriteLine($"Purchased {product}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Water")
                {
                    if (money >= 0.7)
                    {
                        currentMoney = money - 0.7;
                        Console.WriteLine($"Purchased {product}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Crisps")
                {
                    if (money >= 1.5)
                    {
                        currentMoney = money - 1.5;
                        Console.WriteLine($"Purchased {product}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Soda")
                {
                    if (money >= 0.8)
                    {
                        currentMoney = money - 0.8;
                        Console.WriteLine($"Purchased {product}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Coke")
                {
                    if (money >= 1.0)
                    {
                        currentMoney = money - 1.0;
                        Console.WriteLine($"Purchased {product}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Change: {currentMoney}");


        }
    }
}
