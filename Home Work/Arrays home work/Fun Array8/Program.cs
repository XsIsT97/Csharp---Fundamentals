using System;
using System.Linq;

namespace Fun_Array8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int evenNumbers = 0;
            int oddNumbers = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];

                if (currentNumber % 2 == 0)
                {
                    evenNumbers += currentNumber;
                }
                else
                {
                    oddNumbers += currentNumber;
                }
            }
            int newSum = evenNumbers - oddNumbers;
            Console.WriteLine(newSum);

        }
    }
}
