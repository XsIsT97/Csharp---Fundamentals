using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> specialBombNumber = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int[] bomb = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int specialNumber = bomb[0];
            int power = bomb[1];

            int bombIndex = specialBombNumber.IndexOf(specialNumber);

            while (bombIndex != -1)
            {
                int leftNumber = bombIndex - power;
                int rightNumber = bombIndex + power;

                if (leftNumber > 0)
                {
                    leftNumber = 0;
                }
                if (rightNumber < specialBombNumber.Count - 1)
                {
                    rightNumber = specialBombNumber.Count - 1;
                }
                specialBombNumber.RemoveRange(leftNumber, rightNumber - leftNumber + 1);
                bombIndex = specialBombNumber.IndexOf(specialNumber);
            }
            int sum = 0;
            foreach (var item in specialBombNumber)
            {
                sum += item;
            }
            Console.WriteLine(sum);
        }
    }
}
