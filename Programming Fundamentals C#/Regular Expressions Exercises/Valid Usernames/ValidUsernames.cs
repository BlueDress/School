using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Valid_Usernames
{
    public class ValidUsernames
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var pattern = @"\b[a-zA-Z]\w{2,24}\b";

            var regex = new Regex(pattern);

            var matches = regex.Matches(input);

            var usernames = new List<string>();

            foreach (Match match in matches)
            {
                usernames.Add(match.Value);
            }

            var maxSumLengths = 0;
            var firstString = string.Empty;
            var secondString = string.Empty;

            for (int i = 0; i < usernames.Count - 1; i++)
            {
                var currentSumLengths = usernames[i].Length + usernames[i + 1].Length;

                if (currentSumLengths > maxSumLengths)
                {
                    maxSumLengths = currentSumLengths;
                    firstString = usernames[i];
                    secondString = usernames[i + 1];
                }
            }

            Console.WriteLine(firstString);
            Console.WriteLine(secondString);
        }
    }
}
