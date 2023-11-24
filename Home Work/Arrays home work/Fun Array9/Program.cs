using System;
using System.Linq;

namespace Fun_Array9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] array2 = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int sum = 0;
            bool arraysAreDiffrent = false;

            for (int i = 0; i < array1.Length; i++)
            {
                sum += array2[i];
                if (array1[i] != array2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    arraysAreDiffrent = true;
                    break;
                }
            }
            if (!arraysAreDiffrent)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }
    }
}
