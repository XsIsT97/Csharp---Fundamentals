using System;

namespace Fun_work15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input a number
            int number = int.Parse(Console.ReadLine());

            // Check if the number is strong
            int originalNumber = number;
            int sum = 0;

            // Calculate factorial without using a separate function
            while (number > 0)
            {
                int digit = number % 10;
                int factorial = 1;

                // Calculate factorial for each digit
                for (int i = 2; i <= digit; i++)
                {
                    factorial *= i;
                }

                sum += factorial;
                number /= 10;
            }

            // Print the result
            if (sum == originalNumber)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
