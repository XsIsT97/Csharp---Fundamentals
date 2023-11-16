using System;

namespace Fun_work13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int newI = 0;

            for (int i = start; i <= end; i++)
            {
                Console.Write($"{i} ");
                newI += i;
            }
            Console.WriteLine("");
            Console.WriteLine($"Sum: {newI}");
        }
    }
}
