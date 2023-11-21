using System;

namespace Fun_work23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the distance in meters:");

            if (int.TryParse(Console.ReadLine(), out int distanceInMeters))
            {
                double distanceInKilometers = distanceInMeters / 1000.0;

                Console.WriteLine($"Distance in kilometers: {distanceInKilometers:F2} km");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
    }
}
