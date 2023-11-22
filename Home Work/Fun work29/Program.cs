using System;

namespace Fun_work29
{
    internal class Program
    {
        static void Main()
        {
            // Input
            Console.WriteLine("Enter the first line:");
            string line1 = Console.ReadLine();

            Console.WriteLine("Enter the second line:");
            string line2 = Console.ReadLine();

            Console.WriteLine("Enter the third line:");
            string line3 = Console.ReadLine();

            // Process and Output
            Console.WriteLine("Reversed lines with space between them:");
            Console.WriteLine(ReverseString(line3) + " " + ReverseString(line2) + " " + ReverseString(line1));
        }

        // Method to reverse a string
        static string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
