using System;
using System.Linq;

namespace The_Imitation_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Decode")
            {
                string[] commandArguments = command
                    .Split('|', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string action = commandArguments[0];

                if (action == "Move")
                {
                    int lettersToMove = int.Parse(commandArguments[1]);

                    message = MoveLetters(message, lettersToMove);
                }
                else if (action == "Insert")
                {
                    int index = int.Parse(commandArguments[1]);
                    string value = commandArguments[2];

                    message = message.Insert(index, value);
                }
                else if (action == "ChangeAll")
                {
                    string substring = commandArguments[1];
                    string replasment = commandArguments[2];

                    message = message.Replace(substring, replasment);
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"The decrypted message is: {message}");
        }

        static string MoveLetters(string message, int lettersNum)
        {
            string substring = string.Empty;

            for (int i = 0; i < lettersNum; i++)
            {
                substring += message[i];
            }

            message = message.Remove(0, lettersNum);

            return message + substring;
        }
    }
}
