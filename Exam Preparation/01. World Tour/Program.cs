using System;
using System.Linq;

namespace _01._World_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string  stopStr = Console.ReadLine();

            string commandInfo = Console.ReadLine();

            while (commandInfo != "Travel")
            {
                string[] commandArg = commandInfo
                    .Split(':', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string cmdType = commandArg[0];

                if (cmdType == "Add Stop")
                {
                    int insertIndex = int.Parse(commandArg[1]);
                    string insertString = commandArg[2];

                    stopStr = InsertStringAtIndex(stopStr, insertIndex, insertString);

                    Console.WriteLine(stopStr);
                }
                else if (cmdType == "Remove Stop")
                {
                    int startIndex = int.Parse(commandArg[1]);
                    int endIndex = int.Parse(commandArg[2]);

                    stopStr = RemoveStringInRange(stopStr, startIndex, endIndex);

                    Console.WriteLine(stopStr);
                }
                else if (cmdType == "Switch")
                {
                    string oldString = commandArg[1];
                    string newString = commandArg[2];

                    stopStr = ReplaceAllIndexes(stopStr, oldString, newString);

                    Console.WriteLine(stopStr);
                }

                commandInfo = Console.ReadLine();
            }


            Console.WriteLine($"Ready for world tour! Planned stops: {stopStr}");
        }
        
        static string InsertStringAtIndex(string stopStr, int insertIndex, string insertString)
        {
            if (!IsIndexValid(stopStr, insertIndex))
            {
                return stopStr;
            }

            string modifiedString = stopStr.Insert(insertIndex, insertString);
            return modifiedString;
        }

        static string RemoveStringInRange(string originalString, int startIndex, int endIndex)
        {
            if (!IsIndexValid(originalString, startIndex))
            {
                //If startIndex is invalid, then we return original state of the string
                return originalString;
            }

            if (!IsIndexValid(originalString, endIndex))
            {
                //If endIndex is invalid, then we return original state of the string
                return originalString;
            }

            string modifiedString = originalString.Remove(startIndex, endIndex - startIndex + 1);
            return modifiedString;
        }

        static string ReplaceAllIndexes(string originalString, string oldString, string newString)
        {
            string modifiedString = originalString.Replace(oldString, newString);
            return modifiedString;
        }

        static bool IsIndexValid(string str, int index)
        {
            return index >= 0 && index < str.Length;
        }
    }
}
