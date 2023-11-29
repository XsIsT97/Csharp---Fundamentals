using System;

namespace _03._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstString = Console.ReadLine();
            string secondString = Console.ReadLine();

            PrintCharactersBetween(firstString, secondString);
        }
        static void PrintCharactersBetween(char str1, char str2)
        {
            char char1 = str1[0];
            char char2 = str2[0];
            // Swap characters if needed
            if (char1 > char2)
            {
                char temp = char1;
                char1 = char2;
                char2 = temp;
            }

            for (char i = (char)(char1 + 1); i < char2; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }
    }
}
