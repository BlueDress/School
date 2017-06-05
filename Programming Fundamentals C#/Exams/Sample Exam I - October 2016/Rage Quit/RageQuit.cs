using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Rage_Quit
{
    public class RageQuit
    {
        public static void Main()
        {
            var inputString = Console.ReadLine().ToUpper();
            var pattern = @"[^0-9]+\d+";

            var listOfMatches = new List<string>();
            var uniqueCharacters = new HashSet<char>();
            var rageMessages = new Dictionary<string, int>();

            foreach (var symbol in inputString)
            {
                if (!char.IsNumber(symbol))
                {
                    uniqueCharacters.Add(symbol);
                }
            }

            foreach (Match match in Regex.Matches(inputString, pattern))
            {
                listOfMatches.Add(match.ToString());
            }

            foreach (var match in listOfMatches)
            {
                var indexOfNumber = 0;

                foreach (var symbol in match)
                {
                    if (char.IsNumber(symbol))
                    {
                        indexOfNumber = match.IndexOf(symbol);
                        break;
                    }
                }

                var timesToPrint = match.Substring(indexOfNumber, match.Length - indexOfNumber);
                var stringToPrint = match.Substring(0, match.Length - timesToPrint.Length);

                rageMessages[stringToPrint] = int.Parse(timesToPrint);
            }

            Console.WriteLine($"Unique symbols used: {uniqueCharacters.Count}");

            foreach (var message in rageMessages)
            {
                for (int i = 0; i < message.Value; i++)
                {
                    Console.Write(message.Key);
                }
            }

            Console.WriteLine();
        }
    }
}
