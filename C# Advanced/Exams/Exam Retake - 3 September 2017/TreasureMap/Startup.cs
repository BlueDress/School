using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace TreasureMap
{
    public class Startup
    {
        public static void Main()
        {
            var numberOfLines = int.Parse(Console.ReadLine());

            var wordPattern = @"\b[a-zA-Z]{4}\b";
            var numberAndPassworPattern = @"(?<=\D)([0-9]{3})-([0-9]{6}|[0-9]{4})(?=\D)";

            for (int i = 0; i < numberOfLines; i++)
            {
                var input = Console.ReadLine();
                var stringsToCheck = new List<string>();
                var startIndex = 0;

                while (true)
                {
                    var indexOfSharp = input.IndexOf('#', startIndex);
                    var indexOfAMark = input.IndexOf('!', startIndex);

                    if (indexOfAMark < 0 || indexOfSharp < 0)
                    {
                        break;
                    }

                    var stringToCheck = input.Substring(Math.Min(indexOfSharp, indexOfAMark), Math.Abs(indexOfSharp - indexOfAMark) + 1);
                    stringsToCheck.Add(stringToCheck);

                    startIndex = Math.Max(indexOfSharp, indexOfAMark) + 1;
                }

                var stringsWithMatches = new List<string>();

                foreach (var stringToCheck in stringsToCheck)
                {
                    var wordMatches = Regex.Matches(stringToCheck, wordPattern);
                    var numberAndPasswordMatches = Regex.Matches(stringToCheck, numberAndPassworPattern);

                    if (wordMatches.Count > 0 && numberAndPasswordMatches.Count > 0)
                    {
                        stringsWithMatches.Add(stringToCheck);
                    }
                }

                var stringToExtractFrom = stringsWithMatches[stringsWithMatches.Count / 2];

                var matchedWords = Regex.Matches(stringToExtractFrom, wordPattern);
                var matchedNumberAndPassword = Regex.Matches(stringToExtractFrom, numberAndPassworPattern);

                var streetName = matchedWords[0].ToString();
                var streetNumber = matchedNumberAndPassword[matchedNumberAndPassword.Count - 1].Groups[1];
                var password = matchedNumberAndPassword[matchedNumberAndPassword.Count - 1].Groups[2];

                Console.WriteLine($"Go to str. {streetName} {streetNumber}. Secret pass: {password}.");
            }
        }
    }
}
