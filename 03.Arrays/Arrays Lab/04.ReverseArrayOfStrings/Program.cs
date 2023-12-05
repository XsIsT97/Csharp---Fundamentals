using System;

namespace _04.ReverseArrayOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write($"{arr[i]} ");
            }
        }
    }
}
