using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] namesArrey = new string[]
            //{
            //    "Gosho",
            //    "Galin",
            //    "Georgi",
            //    "Ivan",
            //};

            ////List<string> names = new List<string>(namesArrey);

            ////List<string> names = namesArrey.ToList();

            ////Console.WriteLine(names.Remove("Maria"));
            ////names.Insert(0, "Maria");

            //Console.WriteLine(String.Join(",", names));



            //int numberOfElements = int.Parse(Console.ReadLine());
            //List<int> elements = new List<int>();

            //for (int i = 0; i < numberOfElements; i++)
            //{
            //    int currentElement = int.Parse(Console.ReadLine());
            //    elements.Add(currentElement);
            //}
            //Console.WriteLine(String.Join(",", elements));

            //List<string> rawInput = Console.ReadLine().Split().ToList();
            //List<int> number = new List<int>();

            //for (int i = 0; i < rawInput.Count; i++)
            //{
            //    int crrentElement = int.Parse(rawInput[i]);
            //    number.Add(crrentElement);
            //}
            //Console.WriteLine(String.Join(",", number));

            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
        }
    }
}
