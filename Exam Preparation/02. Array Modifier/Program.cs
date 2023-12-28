using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Array_Modifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lineToWork = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> newList = new List<int>();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] indexes = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string action = indexes[0];

                if (action == "swap")
                {
                    int index1 = int.Parse(indexes[1]);
                    int index2 = int.Parse(indexes[2]);
                    for (int i = 0; i < lineToWork.Count; i++)
                    {
                        if (lineToWork[i] == index1)
                        {
                            int temp = index1;
                            index1 = index2;
                            index2 = temp;
                            break;
                        }
                    }
                }
                else if (action == "multiply")
                {

                    int index1 = int.Parse(indexes[1]);
                    int index2 = int.Parse(indexes[2]);
                    int multiplayIndex = 0;
                    multiplayIndex = index1 * index2;
                }
                else if (action == "decrease")
                {
                    for (int i = 0; i < lineToWork.Count; i++)
                    {
                        int newNumber = 0;
                        newNumber = lineToWork[i] - 1;
                        newList.Add(newNumber);
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(',', newList));
        }
    }
}
