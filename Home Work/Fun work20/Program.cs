using System;

namespace Fun_work20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string reversedString = "";

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversedString += input[i];
            }
            Console.WriteLine($"{reversedString}");
        }
    }
}
