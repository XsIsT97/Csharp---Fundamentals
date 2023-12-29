using System;

namespace _01._Bonus_Scoring_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            int numberOfLectures = int.Parse(Console.ReadLine());
            int aditionalBonus = int.Parse(Console.ReadLine());
            double totalBonus = 0;
            int maxAttendences = 0;

            for (int i = 0; i < numberOfStudents; i++)
            {
                int attendences = int.Parse(Console.ReadLine());
                double bonus = (double)attendences / numberOfLectures * (5 + aditionalBonus);

                if (bonus > totalBonus)
                {
                    totalBonus = bonus;
                    maxAttendences = attendences;
                }
            }
            totalBonus = Math.Ceiling(totalBonus);

            Console.WriteLine($"Max Bonus: {totalBonus}.");
            Console.WriteLine($"The student has attended {maxAttendences} lectures.");
        }
    }
}
