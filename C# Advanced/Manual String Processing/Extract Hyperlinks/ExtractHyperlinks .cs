using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Extract_Hyperlinks
{
    public class Program
    {
        public static void Main()
        {
            var pattern = @"<a[^>]*href\s*=\s*('.*?'|"".*?""|[^>\s]*)(\s|>)";
            var sb = new StringBuilder();

            while (true)
            {
                var input = Console.ReadLine();

                if (input.Equals("END"))
                {
                    break;
                }
                else
                {
                    sb.Append(input);
                }
            }

            var text = sb.ToString();

            var matches = Regex.Matches(text, pattern);
            var listOfMatches = new List<string>();

            foreach (Match match in matches)
            {
                listOfMatches.Add(match.Groups[1].ToString());
            }

            foreach (var match in listOfMatches)
            {
                if (match.StartsWith("'") || match.StartsWith("\""))
                {
                    Console.WriteLine(string.Join("", match.Skip(1).Take(match.Length - 2)));
                }
                else
                {
                    Console.WriteLine(match);
                }
            }
        }
    }
}
