using System;

namespace _01._Counter_Strike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            int killedEnemys = 0;
            int thirdBattlePrice = 0;

            string command = Console.ReadLine();
            while (command != "End of battle")
            {
                int distanceToEnemy = int.Parse(command);

                if (energy >= distanceToEnemy)
                {
                    killedEnemys++;
                    energy -= distanceToEnemy;
                    thirdBattlePrice++;
                    if (thirdBattlePrice == 3)
                    {
                        energy += killedEnemys;
                        thirdBattlePrice = 0;
                    }
                }
                else if (energy <= distanceToEnemy)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {killedEnemys} won battles and {energy} energy");
                    return;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Won battles: {killedEnemys}. Energy left: {energy}");
        }
    }
}
