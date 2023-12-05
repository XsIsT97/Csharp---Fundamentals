using System;
using System.Collections.Generic;

namespace _04._List_of_Products
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfProducts = int.Parse(Console.ReadLine());
            List<string> newProducts = new List<string>();

            for (int i = 0; i < numberOfProducts; i++)
            {
                string product = Console.ReadLine();
                newProducts.Add(product);
            }
            
            newProducts.Sort();

            for (int i = 0; i < newProducts.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{newProducts[i]}");
            }
        }
    }
}
