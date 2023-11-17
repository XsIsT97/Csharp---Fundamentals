using System;

namespace Fun_work18
{
    internal class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            string lastDigitSpelling = GetLastDigitSpelling(number);

            Console.WriteLine($"{lastDigitSpelling}");
        }

        // Method to get the English spelling of the last digit
        static string GetLastDigitSpelling(int num)
        {
            int lastDigit = Math.Abs(num % 10); // Ensure positive last digit

            switch (lastDigit)
            {
                case 0:
                    return "zero";
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
                default:
                    return ""; // Should not reach here
            }
        }
    }
}
