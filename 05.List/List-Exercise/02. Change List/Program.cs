using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] token = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string action = token[0];

                if (action == "Delete")
                {
                    int element = int.Parse(token[1]);
                    numbers.Remove(element);
                }
                else if (action == "Insert")
                {
                    int element = int.Parse(token[1]);
                    int positon = int.Parse(token[2]);

                    numbers.Insert(positon, element);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
