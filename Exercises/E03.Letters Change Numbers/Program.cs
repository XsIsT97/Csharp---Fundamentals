using System;
using System.Linq;

namespace E03.Letters_Change_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            decimal sum = 0;

            foreach (string word in words)
            {
                sum += CalculateSingleWordSum(word);
            }

            Console.WriteLine($"{sum:f2}");
        }

        static decimal CalculateSingleWordSum(string word)
        {
            decimal sum = 0;

            //The first letter and the last letter are not part of the number (-2)
            char firstLetter = word[0];
            char lastLetter = word[word.Length - 1];
            int num = int.Parse(word.Substring(1, word.Length - 2));

            int firstLetterPos = GetAlphabeticalPositionOfCharacter(firstLetter);
            int lastLetterPos = GetAlphabeticalPositionOfCharacter(lastLetter);

            //Check if both letters have valid position
            if (firstLetterPos == -1 || lastLetterPos == -1)
            {
                return 0m;
            }

            if (char.IsUpper(firstLetter))
            {
                sum = (decimal)num / firstLetterPos;
            }
            else if (char.IsLower(firstLetter))
            {
                sum = (decimal)num * firstLetterPos;
            }

            if (char.IsUpper(lastLetter))
            {
                sum -= lastLetterPos;
            }
            else if (char.IsLower(lastLetter))
            {
                sum += lastLetterPos;
            }

            return sum;
        }

        /// <summary>
        /// Returns the position of given letter as character literal in English alphabet.
        /// Returns -1 if the given character is not a letter.
        /// </summary>
        static int GetAlphabeticalPositionOfCharacter(char ch)
        {
            if (!char.IsLetter(ch))
            {
                return -1;
            }

            char chCI = char.ToLowerInvariant(ch);

            return chCI - 96;
        }
    }
}