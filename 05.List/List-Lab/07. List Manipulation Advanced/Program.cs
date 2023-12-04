using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
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
            bool hasChanges = false;

            while (command != "end")
            {
                string[] token = command.Split(' ');
                string action = token[0];

                if (action == "Add")
                {
                    int numberToAdd = int.Parse(token[1]);
                    input.Add(numberToAdd);
                    hasChanges = true;
                }
                else if (action == "Remove")
                {
                    int numberToRemove = int.Parse(token[1]);
                    input.Remove(numberToRemove);
                    hasChanges = true;
                }
                else if (action == "RemoveAt")
                {
                    int numberToRemoveAt = int.Parse(token[1]);
                    input.RemoveAt(numberToRemoveAt);
                    hasChanges = true;
                }
                else if (action == "Insert")
                {
                    int numberToInsert = int.Parse(token[2]);
                    int indexToInsertNumber = int.Parse(token[1]);
                    input.Insert(numberToInsert, indexToInsertNumber);
                    hasChanges = true;
                }
                else if (action == "Contains")
                {
                    int numberContains = int.Parse(token[1]);
                    if (input.Contains(numberContains))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (action == "PrintEven")
                {
                    List<int> evenNumber = input.FindAll(x => x % 2 == 0);
                    Console.WriteLine(string.Join(" ", evenNumber));
                }
                else if (action == "PrintOdd")
                {
                    List<int> oddNumber = input.FindAll(x => x % 2 != 0);
                    Console.WriteLine(string.Join(" ", oddNumber));
                }
                else if (action == "GetSum")
                {
                    int sum = input.Sum();
                    Console.WriteLine(sum);
                }
                else if (action == "Filter")
                {
                    string condition = token[1];
                    int numberToFilter = int.Parse(token[2]);
                    List<int> result = GetFilterdNumber(input, condition, numberToFilter);

                    Console.WriteLine(string.Join(' ', result));
                }
                command = Console.ReadLine();
            }

            if (hasChanges)
            {
                Console.WriteLine(string.Join(" ", input));
            }
        }

        static List<int> GetFilterdNumber(List<int> allNumbers, string conditions, int numberToComare)
        {
            if (conditions == "<")
            {
                List<int> result = allNumbers.FindAll(x => x < numberToComare);
                return result;
            }
            else if (conditions == ">")
            {
                List<int> result = allNumbers.FindAll(x => x > numberToComare);
                return result;
            }
            else if (conditions == "<=")
            {
                List<int> result = allNumbers.FindAll(x => x <= numberToComare);
                return result;
            }
            else if (conditions == ">=")
            {
                List<int> result = allNumbers.FindAll(x => x >= numberToComare);
                return result;
            }
            else
            {
                return allNumbers;
            }
        }
    }
}
