using System;

namespace Counter_Strike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int energi = int.Parse(Console.ReadLine());
            string command = "";
            int wonCount = 0;

            while ((command = Console.ReadLine()) != "End of battle")
            {
                int distance = int.Parse(command);
                if (energi >= distance)
                {
                    energi -= distance;
                    wonCount++;
                    if (wonCount % 3 == 0)
                    {
                        energi += wonCount;
                    }
                }
                else
                {
                    Console.WriteLine($"Not enough energy! Game ends with {wonCount} won battles and {energi} energy");
                    return;
                }
                
            }
            Console.WriteLine($"Won battles: {wonCount}. Energy left: {energi}");
        }
    }
}
