using System;

namespace _8._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double @base = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            double power1 = MathPower(@base, power);
            Console.WriteLine(power1);
        }
        
        static double MathPower(double @base, double power)
        {
            double result = 1;

            for (int i = 0; i < power; i++)
            {
                result = result * @base;
            }

            return result;
        }
    }
}
