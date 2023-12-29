using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Emoji_Detector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            long cool = input.Where(char.IsDigit)
                .Select(digit => int.Parse(digit.ToString()))
                .Aggregate(1, (a, b) => a * b);

            Regex emojiRegex = new Regex(@"(::|\*\*)([A-Z][a-z]{2,})\1");
            var matches = emojiRegex.Matches(input);

            List<string> coolEmojies = new List<string>();

            foreach (Match match in matches)
            {
                string emoji = match.Groups[2].Value;
                int coolness = emoji.Sum(ch => ch);

                if (coolness >= cool)
                {
                    coolEmojies.Add(match.Value);
                }
            }
            Console.WriteLine($"Cool threshold: {cool}");
            Console.WriteLine($"{matches.Count} emojis found in the text. The cool ones are:");
            foreach (var emoji in coolEmojies)
            {
                Console.WriteLine(emoji);
            }
        }
    }
}
