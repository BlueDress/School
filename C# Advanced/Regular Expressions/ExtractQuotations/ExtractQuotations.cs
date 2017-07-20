using System;
using System.Text.RegularExpressions;

namespace ExtractQuotations
{
    public class ExtractQuotations
    {
        public static void Main()
        {
            var pattern = @"(?<=)('|"")(.+?)\1";
            var input = Console.ReadLine();

            var regex = new Regex(pattern);
            var matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Groups[2].Value);
            }
        }
    }
}
