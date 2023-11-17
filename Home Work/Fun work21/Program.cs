using System;

namespace Fun_work21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the sequence of digits (0-9) to type an SMS:");
            string input = Console.ReadLine();

            string result = ConvertDigitsToText(input);

            Console.WriteLine($"Typed SMS: {result}");
        }

        static string ConvertDigitsToText(string input)
        {
            string result = "";
            int length = input.Length;

            for (int i = 0; i < length;)
            {
                char digit = input[i];
                int digitLength = 1;

                // Find the number of consecutive identical digits
                while (i + digitLength < length && input[i + digitLength] == digit)
                {
                    digitLength++;
                }

                // Find the main digit and calculate the offset
                int mainDigit = digit - '0';
                int offset = (mainDigit - 2) * 3;

                if (mainDigit == 8 || mainDigit == 9)
                {
                    offset++;
                }

                // Find the letter index and add it to the ASCII code of 'a'
                int letterIndex = (offset + digitLength - 1) % 3;
                char letter = (char)('a' + offset + letterIndex);

                // Append the letter to the result
                result += letter;

                // Move to the next group of digits
                i += digitLength;
            }

            return result;
        }
    }
}
