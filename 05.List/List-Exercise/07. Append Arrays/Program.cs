using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> listToAppend = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            List<string> result = new List<string>();
            
            for (int i = listToAppend.Count - 1; i >= 0; i--)
            {
                var currentList = listToAppend[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var item in currentList)
                {
                    result.Add(item);
                }
            }
            Console.WriteLine(string.Join(' ', result));
        }
    }
}
