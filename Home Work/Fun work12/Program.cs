using System;
using System.Diagnostics;

namespace Fun_work12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peoples = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfTheWeek = Console.ReadLine();
            double totalPrice = 0;
            double total = 0;

            if (dayOfTheWeek == "Friday")
            {
                if (typeOfGroup == "Students")
                {
                    if (peoples >= 30)
                    {
                        totalPrice = peoples * 8.45;
                        total = totalPrice - (0.15 * totalPrice);
                    }
                    else
                    {
                        total = peoples * 8.45;
                    }
                }
                else if (typeOfGroup == "Business")
                {
                    if (peoples >= 100)
                    {
                        total = (peoples - 10) * 10.90;
                    }
                }
                else if (typeOfGroup == "Regular")
                {
                    if (peoples >= 10 && peoples <= 20)
                    {
                        totalPrice = peoples * 15;
                        total = totalPrice - (0.05 * totalPrice);
                    }
                    else
                    {
                        total = peoples * 15;
                    }
                }
            }
            else if (dayOfTheWeek == "Saturday")
            {
                if (typeOfGroup == "Students")
                {
                    if (peoples >= 30)
                    {
                        totalPrice = peoples * 9.80;
                        total = totalPrice - (0.15 * totalPrice);
                    }
                    else
                    {
                        total = peoples * 9.80;
                    }
                }
                else if (typeOfGroup == "Business")
                {
                    if (peoples >= 100)
                    {
                        total = (peoples - 10) * 15.60;
                    }
                }
                else if (typeOfGroup == "Regular")
                {
                    if (peoples >= 10 && peoples <= 20)
                    {
                        totalPrice = peoples * 20;
                        total = totalPrice - (0.05 * totalPrice);
                    }
                    else
                    {
                        total = peoples * 20;
                    }
                }
            }
            else if (dayOfTheWeek == "Sunday")
            {
                if (typeOfGroup == "Students")
                {
                    if (peoples >= 30)
                    {
                        totalPrice = peoples * 10.46;
                        total = totalPrice - (0.15 * totalPrice);
                    }
                    else
                    {
                        total = peoples * 10.46;
                    }
                }
                else if (typeOfGroup == "Business")
                {
                    if (peoples >= 100)
                    {
                        total = (peoples - 10) * 16;
                    }
                }
                else if (typeOfGroup == "Regular")
                {
                    if (peoples >= 10 && peoples <= 20)
                    {
                        totalPrice = peoples * 22.50;
                        total = totalPrice - (0.05 * totalPrice);
                    }
                    else
                    {
                        total = peoples * 22.50;
                    }
                }
            }
            Console.WriteLine($"Total price: {total:F2}");

        }
    }
}
