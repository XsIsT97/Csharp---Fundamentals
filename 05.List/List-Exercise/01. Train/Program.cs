using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int wagoncapacity = int.Parse(Console.ReadLine());
            int number = 0;

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] tokens = command.Split();

                if (tokens[0] == "Add")
                {
                    number = int.Parse(tokens[1]);
                    wagons = AddWagons(wagons, number);
                }
                else
                {
                    number = int.Parse(tokens[0]);
                    wagons = FitPassengersInWagon(wagons, number, wagoncapacity);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" ", wagons));
        }

        static List<int> AddWagons(List<int> wagons, int number)
        {
            wagons.Add(number);

            return wagons;
        }

        static List<int> FitPassengersInWagon(List<int> wagons, int number, int wagonsCapacity)
        {
            for (int i = 0; i < wagons.Count; i++)
            {
                if ((wagons[i] + number) <= wagonsCapacity)
                {
                    wagons[i] += number;
                    break;
                }
            }

            return wagons;
        }
    }
}
