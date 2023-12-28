using System;

namespace _01._SoftUni_Reception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int employe1 = int.Parse(Console.ReadLine());
            int employe2 = int.Parse(Console.ReadLine());
            int employe3 = int.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            int totalEficianciPerHour = employe1 + employe2 + employe3;
            int hoursCount = 0;

            while (studentsCount > 0)
            {
                hoursCount++;
                if (hoursCount % 4 != 0)
                {
                    studentsCount -= totalEficianciPerHour;
                }
            }
            Console.WriteLine($"Time needed: {hoursCount}h.");
        }
    }
}
