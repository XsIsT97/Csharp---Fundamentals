using System;

namespace Fun_work19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            double totalSpend = 0;

            while (true)
            {
                string game = Console.ReadLine();

                if (game == "Game Time")
                {
                    break;
                }

                double price = 0;

                if (game == "OutFall 4")
                {
                    price = 39.99;
                }
                else if (game == "CS: OG")
                {
                    price = 15.99;
                }
                else if (game == "Zplinter Zell")
                {
                    price = 19.99;
                }
                else if (game == "Honored 2")
                {
                    price = 59.99;
                }
                else if (game == "RoverWatch")
                {
                    price = 29.99;
                }
                else if (game == "RoverWatch Origins Edition")
                {
                    price = 39.99;
                }
                else
                {
                    Console.WriteLine("Not Found");
                    continue;
                }

                if (price > balance)
                {
                    Console.WriteLine("Too Expensive");
                }
                else
                {
                    Console.WriteLine($"Bought {game}");
                    balance -= price;
                    totalSpend += price;
                }

                if (balance <= 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
            }
            Console.WriteLine($"Total spent: ${totalSpend:F2}. Remaining: ${balance:F2}");
        }
    }
}
