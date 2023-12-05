using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> line1 = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> line2 = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int longestList = Math.Max(line1.Count, line2.Count);
            List<int> result = new List<int>();

            for (int i = 0; i < longestList; i++)
            {
                if (i < line1.Count)
                {
                    result.Add(line1[i]);
                }

                if (i < line2.Count)
                {
                    result.Add(line2[i]);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
