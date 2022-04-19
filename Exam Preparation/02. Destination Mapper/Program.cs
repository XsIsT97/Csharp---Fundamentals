using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Destination_Mapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> destination = new List<string>();
            int travelPoint = 0;

            string input = Console.ReadLine();

            //Regex regex = new Regex(@"(\=|\/)(?<destination>[A-Z][A-Za-z]{2,})(\1)");
            string pattern = @"(\=|\/)(?<destination>[A-Z][A-Za-z]{2,})(\1)";

            MatchCollection matches = Regex.Matches(input, pattern);
            //MatchCollection matches2 = regex.Matches(input);

            foreach (Match currMatch in matches)
            {
                string currentDestination = currMatch.Groups["destination"].Value;
                //string matchValue = currMatch.Groups[0].Value;

                destination.Add(currentDestination);
                travelPoint += currentDestination.Length;
            }

            Console.WriteLine($"Destinations: {string.Join(", ", destination)}");
            Console.WriteLine($"Travel Points: {travelPoint}");
        }
    }
}
