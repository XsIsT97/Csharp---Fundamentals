﻿using System;

namespace _06._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            PrintMiddleCh(word);
        }

        static void PrintMiddleCh(string word)
        {
            if (word.Length % 2 == 0)
            {
                Console.Write(word[word.Length / 2 - 1]);
                Console.WriteLine(word[word.Length / 2]);
            }
            else
            {
                Console.WriteLine(word[word.Length / 2]);
            }
        }
    }
}
