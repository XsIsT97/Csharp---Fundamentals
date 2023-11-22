using System;

namespace Fun_work28
{
    internal class Program
    {
        static void Main()
        {
            
            int n;

            while (!int.TryParse(Console.ReadLine(), out n) || n < 1)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer:");
            }

            for (int i = 1; i <= n; i++)
            {
                int sum = 0;

                while (i != 0)
                {
                    sum += i % 10;
                    i /= 10;
                }
                bool isSpecial = sum == 5 || sum == 7 || sum == 11;
                Console.WriteLine($"{i}->{isSpecial}");
            }
        }

    }
}
