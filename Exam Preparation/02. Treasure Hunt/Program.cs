using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Treasure_Hunt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> ches = Console.ReadLine()
            .Split('|', StringSplitOptions.RemoveEmptyEntries)
            .ToList();

            string command;
            while ((command = Console.ReadLine()) != "Yohoho!")
            {
                string[] arguments = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string action = arguments[0];

                if (action == "Loot")
                {
                    for (int i = 1; i < arguments.Length; i++)
                    {
                        if (!ches.Contains(arguments[i]))
                        {
                            ches.Insert(0, arguments[i]);
                        }
                    }
                }
                else if (action == "Drop")
                {
                    int index = int.Parse(arguments[1]);
                    if (index >= 0 && index < ches.Count)
                    {
                        string item = ches[index];
                        ches.RemoveAt(index);
                        ches.Add(item);
                    }
                }
                else if (action == "Steal")
                {
                    int count = int.Parse(arguments[1]);
                    int itemsToSteal = Math.Min(count, ches.Count);
                    var stolenItems = ches.Skip(ches.Count - itemsToSteal).ToList();
                    ches.RemoveRange(ches.Count - itemsToSteal, itemsToSteal);
                    Console.WriteLine(string.Join(", ", stolenItems));
                }
            }

            if (ches.Count > 0)
            {
                double averageGain = ches.Sum(item => item.Length) / (double)ches.Count;
                Console.WriteLine($"Average treasure gain: {averageGain:F2} pirate credits.");
            }
            else
            {
                Console.WriteLine("Failed treasure hunt.");
            }
        }
    }
}
