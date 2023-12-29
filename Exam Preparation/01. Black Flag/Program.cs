using System;

namespace _01._Black_Flag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double plunderForDay = double.Parse(Console.ReadLine());
            double expectPlunder = double.Parse(Console.ReadLine());
            double totalPlunder = 0;

            for (int i = 1; i <= days; i++)
            {
                totalPlunder += plunderForDay;
                if (i % 3 == 0)
                {
                    double aditionalPlunder = plunderForDay * 0.50;
                    totalPlunder += aditionalPlunder;
                }

                if (i % 5 == 0)
                {;
                    totalPlunder -= totalPlunder * 0.30;
                }
            }

            double percentage = (totalPlunder / expectPlunder) * 100;

            if (totalPlunder >= expectPlunder)
            {
                Console.WriteLine($"Ahoy! {totalPlunder:F2} plunder gained.");
            }
            else
            {
                Console.WriteLine($"Collected only {percentage:F2}% of the plunder.");
            }
        }
    }
}
