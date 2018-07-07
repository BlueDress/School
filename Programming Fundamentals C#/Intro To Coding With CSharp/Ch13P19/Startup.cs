using System;
using System.Text.RegularExpressions;

namespace Ch13P19
{
    public class Startup
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"(?<=\s)[a-zA-Z0-9]+[._\-a-zA-Z0-9]*@[a-zA-Z]+([-.][a-zA-Z]+)*\.[a-z]{2,}";
            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
