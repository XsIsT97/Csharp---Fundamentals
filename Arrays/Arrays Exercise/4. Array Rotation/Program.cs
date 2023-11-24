using System;
using System.Linq;

namespace Fun_Array4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rotationsCount = int.Parse(Console.ReadLine());
            int rotationsCountReduced = rotationsCount % arr.Length;

            for (int rot = 1; rot <= rotationsCountReduced; rot++)
            {
                int firstEl = arr[0]; //Not to lose first element
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    
                    arr[i] = arr[i + 1];
                }
                arr[arr.Length - 1] = firstEl;
            }

            Console.WriteLine(String.Join(" ", arr));
        }
    }
}
