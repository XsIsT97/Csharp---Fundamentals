using System;
using System.Linq;

namespace Activation_Keys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string activationKey = Console.ReadLine();

            string command;
            while ((command = Console.ReadLine()) != "Generate")
            {
                string[] commandArguments = command
                    .Split(">>>", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string action = commandArguments[0];

                if (action == "Contains")
                {
                    string substring = commandArguments[1];

                    if (activationKey.Contains(substring))
                    {
                        Console.WriteLine($"{activationKey} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (action == "Flip")
                {
                    string upperOrLower = commandArguments[1];
                    int startindex = int.Parse(commandArguments[2]);
                    int endindex = int.Parse(commandArguments[3]);

                    string subStr = activationKey.Substring(startindex, endindex - startindex);
                    string flipped = "";

                    if (upperOrLower == "Upper")
                    {
                        for (int i = 0; i < subStr.Length; i++)
                        {
                            flipped += char.ToUpper(subStr[i]);
                        }

                    }
                    else if (upperOrLower == "Lower")
                    {
                        for (int i = 0; i < subStr.Length; i++)
                        {
                            flipped += char.ToLower(subStr[i]);
                        }
                    }

                    activationKey = activationKey.Replace(subStr, flipped);
                    Console.WriteLine(activationKey);
                }
                else if (action == "Slice")
                {
                    int startIndex = int.Parse(commandArguments[1]);
                    int endIndex = int.Parse(commandArguments[2]);

                    string substring = activationKey.Substring(startIndex, endIndex - startIndex);
                    activationKey = activationKey.Replace(substring, "");
                    Console.WriteLine(activationKey);
                }
            }
            Console.WriteLine($"Your activation key is: {activationKey}");
        }
    }
}
