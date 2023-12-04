using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] token = command.Split(' ');
                string action = token[0];

                if (action == "Add")
                {
                    int numberToAdd = int.Parse(token[1]);
                    input.Add(numberToAdd);
                }
                else if (action == "Remove")
                {
                    int numberToRemove = int.Parse(token[1]);
                    input.Remove(numberToRemove);
                }
                else if (action == "RemoveAt")
                {
                    int numberToRemoveAt = int.Parse(token[1]);
                    input.RemoveAt(numberToRemoveAt);
                }
                else if (action == "Insert")
                {
                    int numberToInsert = int.Parse(token[2]);
                    int indexToInsertNumber = int.Parse(token[1]);
                    input.Insert(numberToInsert, indexToInsertNumber);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(' ', input));
        }
    }
}
