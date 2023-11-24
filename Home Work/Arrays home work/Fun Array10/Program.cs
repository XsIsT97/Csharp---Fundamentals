using System;
using System.Linq;

namespace Fun_Array10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int firstLenght = array.Length;

            for (int i = 0; i < firstLenght - 1; i++)
            {
                int[] condens = new int[array.Length - 1];

                for (int j = 0; j < array.Length - 1; j++)
                {
                    condens[j] = array[j] + array[j + 1];
                }
                array = condens;
            }
            Console.WriteLine(array[0]);
        }
    }
}
