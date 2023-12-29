using System;
using System.Linq;

namespace _03._Man_O_War
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] pirateShip = Console.ReadLine()
                .Split('>', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] warShip = Console.ReadLine()
                .Split('>', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int maxHealt = int.Parse(Console.ReadLine());

            string commands = Console.ReadLine();
            while (commands != "Retire")
            {
                string[] arguments = commands.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string action = arguments[0];

                if (action == "Fire")
                {
                    int index = int.Parse(arguments[1]);
                    int demage = int.Parse(arguments[2]);

                    if (index >= 0 && index <= warShip.Length)
                    {
                        warShip[index] -= demage;
                        if (warShip[index] <= 0)
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            return;
                        }
                    }
                }
                else if (action == "Defend")
                {
                    int startIndex = int.Parse(arguments[1]);
                    int endIndex = int.Parse(arguments[2]);
                    int demage = int.Parse(arguments[3]);

                    if (startIndex >= 0 && startIndex < pirateShip.Length && endIndex >= 0 && endIndex < pirateShip.Length)
                    {
                        for (int i = startIndex; i < endIndex; i++)
                        {
                            pirateShip[i] -= demage;
                            if (pirateShip[i] <= 0)
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                return;
                            }
                        }
                    }
                }
                else if (action == "Repair")
                {
                    int index = int.Parse(arguments[1]);
                    int healt = int.Parse(arguments[2]);

                    if (index >= 0 && index < pirateShip.Length)
                    {
                        pirateShip[index] += healt;
                        if (pirateShip[index] > maxHealt)
                        {
                            pirateShip[index] = maxHealt;
                        }
                    }
                }
                else if (action == "Status")
                {
                    int count = pirateShip.Count(section => section < maxHealt * 0.20);
                }
                commands = Console.ReadLine();
            }
            Console.WriteLine($"Pirate ship status: {pirateShip.Sum()}");
            Console.WriteLine($"Warship status: {warShip.Sum()}");
        }
    }
}
