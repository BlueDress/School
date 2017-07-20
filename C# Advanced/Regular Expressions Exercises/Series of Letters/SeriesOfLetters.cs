using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Series_of_Letters
{
    class SeriesOfLetters
    {
        static void Main(string[] args)
        {
            var pattern = @"([a-z|A-Z])\1*";
            var regex = new Regex(pattern);

            var input = Console.ReadLine();
            var matches = regex.Matches(input);

            var sb = new StringBuilder();

            foreach (Match match in matches)
            {
                sb.Append(match.Groups[1]);
            }

            var result = sb.ToString();

            Console.WriteLine(result);
        }
    }
}
