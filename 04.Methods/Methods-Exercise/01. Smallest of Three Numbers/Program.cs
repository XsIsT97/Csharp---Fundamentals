﻿using System;

namespace _01._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintSmolNumber();
        }

        static void PrintSmolNumber()
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            if (number1 < number2 && number1 < number3)
            {
                Console.WriteLine(number1);
            }
            else if (number2 < number1 && number2 < number3)
            {
                Console.WriteLine(number2);
            }
            else if (number3 < number1 && number3 < number2)
            {
                Console.WriteLine(number3);
            }
        }
    }
}
