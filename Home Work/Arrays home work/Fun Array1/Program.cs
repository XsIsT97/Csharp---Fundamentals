using System;

namespace Fun_Array1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOFNUmbers = int.Parse(Console.ReadLine());
            int[] items = new int[numberOFNUmbers];

            for (int i = 0; i < numberOFNUmbers; i++)
            {
                items[i] = int.Parse(Console.ReadLine());
            }

            for (int i = items.Length - 1; i >= 0; i--)
            {
                Console.Write($"{items[i]} ");
            }
        }
    }
}
