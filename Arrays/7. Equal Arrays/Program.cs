using System;
using System.Linq;

namespace _7._Equal_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firsArrey = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int[] secondArrey = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int sum = 0;
            bool arraysAreDiffrend = false;

            for (int i = 0; i < firsArrey.Length; i++)
            {
                sum += secondArrey[i];
                if (firsArrey[i] != secondArrey[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    arraysAreDiffrend = true;
                    break;
                    //Environment.Exit(0);
                    //return;
                }
            }
            if (!arraysAreDiffrend)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }
    }
}
