using System;

namespace Fun_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dayNumber = int.Parse(Console.ReadLine());

            string[] daysOfTheWeek = new string[]
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            if (dayNumber >= 1 && dayNumber <= daysOfTheWeek.Length)
            {
                Console.WriteLine(daysOfTheWeek[dayNumber]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
