using System;
using System.Linq;

namespace MU_Online
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine()
                .Split('|')
                .ToArray();

            int health = 100;
            double coin = 0;

            for (int room = 0; room < command.Length; room++)
            {
                string[] currendCommand = command[room].Split();

                if (currendCommand[0] == "potion")
                {
                    int pastHealth = health;
                    int healdPoints = int.Parse(currendCommand[1]);
                    health += healdPoints;

                    if (health > 100)
                    {
                        health = 100;
                    }

                    int gaintHealth = health - pastHealth;

                    if (pastHealth == 100)
                    {
                        gaintHealth = 0;
                    }
                    Console.WriteLine($"You healed for {gaintHealth} hp.");
                    Console.WriteLine($"Current health: {health} hp.");
                }
                else if (currendCommand[0] == "chest")
                {
                    int foundCoin = int.Parse(currendCommand[1]);
                    coin += foundCoin;
                    Console.WriteLine($"You found {foundCoin} bitcoins.");
                }
                else
                {
                    string currentMonster = currendCommand[0];
                    int monsterPoint = int.Parse(currendCommand[1]);
                    health -= monsterPoint;

                    if (health > 0)
                    {
                        Console.WriteLine($"You slayed {currentMonster}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {currentMonster}.");
                        Console.WriteLine($"Best room: {room + 1}");
                        return;
                    }
                }

            }

            Console.WriteLine("You've made it!");
            Console.WriteLine($"Bitcoins: {coin}");
            Console.WriteLine($"Health: {health}");
        }
    }
}
