using System;
using System.Text.RegularExpressions;

namespace p01Hogwarts
{
    class Program
    {
        static void Main(string[] args)
        {
            string spell = Console.ReadLine();

            string command;
            while ((command = Console.ReadLine()) != "Abracadabra")
            {
                string[] commandArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string action = commandArgs[0];

                if (action == "Abjuration")
                {
                    spell = Regex.Replace(spell, @"[a-z]*", n => "" + n.ToString().ToUpper());
                    Console.WriteLine(spell);
                }
                else if (action == "Necromancy")
                {
                    spell = Regex.Replace(spell, @"[A-Z]*", n => "" + n.ToString().ToLower());
                    Console.WriteLine(spell);
                }
                else if (action == "Illusion")
                {
                    int index = int.Parse(commandArgs[1]);
                    string letter = commandArgs[2];

                    if (index > spell.Length - 1 || index < 0)
                    {
                        Console.WriteLine("The spell was too weak");
                        continue;
                    }

                    spell = spell.Remove(index, 1);
                    spell = spell.Insert(index, letter);
                    Console.WriteLine("Done!");
                }
                else if (action == "Divination")
                {
                    string firstSubstring = commandArgs[1];
                    string secondSubstring = commandArgs[2];

                    if (!spell.Contains(firstSubstring))
                    {
                        continue;
                    }

                    spell = spell.Replace(firstSubstring, secondSubstring);
                    Console.WriteLine(spell);
                }
                else if (action == "Alteration")
                {
                    string substring = commandArgs[1];

                    if (!spell.Contains(substring))
                    {
                        continue;
                    }

                    spell = spell.Replace(substring, "");
                    Console.WriteLine(spell);
                }
            }
        }
    }
}
