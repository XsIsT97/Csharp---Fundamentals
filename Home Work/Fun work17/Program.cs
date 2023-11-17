using System;

namespace Fun_work17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());

            // Sort the numbers in descending order
            if (num1 < num2)
            {
                double temp = num1;
                num1 = num2;
                num2 = temp;
            }

            if (num1 < num3)
            {
                double temp = num1;
                num1 = num3;
                num3 = temp; ;
            }

            if (num2 < num3)
            {
                double temp = num2;
                num2 = num3;
                num3 = temp;
            }

            // Print the sorted numbers
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);


        }
    }
}
