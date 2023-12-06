using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> playerHandOne = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> playerHandTwo = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int sum = 0;

            while (playerHandOne.Count != 0 || playerHandTwo.Count != 0)
            {
                if (playerHandOne[0] == playerHandTwo[0])
                {
                    playerHandOne.RemoveAt(0);
                    playerHandTwo.RemoveAt(0);
                }
                else if (playerHandOne[0] > playerHandTwo[0])
                {
                    playerHandOne.Add(playerHandTwo[0]);
                    playerHandOne.Add(playerHandOne[0]);
                    playerHandOne.RemoveAt(0);
                    playerHandTwo.RemoveAt(0);
                }
                else if (playerHandOne[0] < playerHandTwo[0])
                {
                    playerHandTwo.Add(playerHandOne[0]);
                    playerHandTwo.Add(playerHandTwo[0]);
                    playerHandTwo.RemoveAt(0);
                    playerHandOne.RemoveAt(0);
                }

                if (playerHandOne.Count == 0)
                {
                    sum = playerHandTwo.Sum();
                    Console.WriteLine($"Second player wins! Sum: {sum}");
                    break;
                }
                else if (playerHandTwo.Count == 0)
                {
                    sum = playerHandOne.Sum();
                    Console.WriteLine($"First player wins! Sum: {sum}");
                    break;
                }
            }
        }
    }
}
