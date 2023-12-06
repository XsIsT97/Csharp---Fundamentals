using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] token = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string action = token[0];

                if (action == "Add")
                {
                    int newNumber = int.Parse(token[1]);
                    numbers.Add(newNumber);
                }
                else if (action == "Insert")
                {
                    int newNumber = int.Parse(token[1]);
                    int index = int.Parse(token[2]);
                    if (IsIndexInvalid(numbers, index))
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbers.Insert(index, newNumber);
                }
                else if (action == "Remove")
                {
                    int indexToRemove = int.Parse(token[1]);
                    if (IsIndexInvalid(numbers, indexToRemove))
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbers.RemoveAt(indexToRemove);
                }
                else if (action == "Shift")
                {
                    string direction = token[1];
                    int count = int.Parse(token[2]);

                    if (direction == "left")
                    {
                        ShiftLeft(numbers, count);
                    }
                    else
                    {
                        ShiftRight(numbers, count);
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(' ', numbers));
        }
        static bool IsIndexInvalid(List<int> numbers, int index)
            => index < 0 || index >= numbers.Count;

        static void ShiftLeft(List<int> numbers, int count)
        {
            for (int i = 0; i < count; i++)
            {
                int firstNumber = numbers[0];
                numbers.RemoveAt(0);
                numbers.Add(firstNumber);
            }
        }

        static void ShiftRight(List<int> numbers, int count)
        {
            for (int i = 0; i < count; i++)
            {
                int lastNumbers = numbers[numbers.Count - 1];
                numbers.RemoveAt(numbers.Count - 1);
                numbers.Insert(0, lastNumbers);
            }
        }
    }
}
