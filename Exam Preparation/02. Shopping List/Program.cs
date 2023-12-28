using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shopping_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                .Split('!', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command = Console.ReadLine();
            while (command != "Go Shopping!")
            {
                string[] arguments = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string action = arguments[0];
                if (action == "Urgent")
                {
                    string item = arguments[1];
                    if (!list.Contains(item))
                    {
                        list.Insert(0, item);
                    }
                }
                else if (action == "Unnecessary")
                {
                    string item = arguments[1];
                    if (list.Contains(item))
                    {
                        list.Remove(item);
                    }
                }
                else if (action == "Correct")
                {
                    string oldItem = arguments[1];
                    string newItem = arguments[2];

                    int index = list.IndexOf(oldItem);
                    if (index != -1)
                    {
                        list[index] = newItem;
                    }
                }
                else if (action == "Rearrange")
                {
                    string item = arguments[1];
                    if (list.Contains(item))
                    {
                        list.Remove(item);
                        list.Add(item);
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", list));
        }
    }
}
