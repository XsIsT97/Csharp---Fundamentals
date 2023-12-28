using System;

namespace _01._Guinea_Pig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double food = double.Parse(Console.ReadLine());
            double hay = double.Parse(Console.ReadLine());
            double cover = double.Parse(Console.ReadLine());
            double pigWeight = double.Parse(Console.ReadLine());
            bool isEverythingOK = true;

            for (int i = 1; i <= 30; i++)
            {
                food -= 0.3;

                if (food <= 0)
                {
                    Console.WriteLine($"Merry must go to the pet store!");
                    isEverythingOK = false;
                    break;
                }

                if (i % 2 == 0)
                {
                    double hayToGive = 0;
                    hayToGive = food * 0.05;
                    hay -= hayToGive;

                    if (hay <= 0)
                    {
                        Console.WriteLine($"Merry must go to the pet store!");
                        isEverythingOK = false;
                        break;
                    }
                }

                if (i % 3 == 0)
                {
                    double coverToGive = 0;
                    coverToGive = pigWeight / 3;
                    cover -= coverToGive;

                    if (cover <= 0)
                    {
                        Console.WriteLine($"Merry must go to the pet store!");
                        isEverythingOK = false;
                        break;
                    }
                }
            }
            if (isEverythingOK)
            {
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {food:F2}, Hay: {hay:F2}, Cover: {cover:F2}.");
            }
        }
    }
}
