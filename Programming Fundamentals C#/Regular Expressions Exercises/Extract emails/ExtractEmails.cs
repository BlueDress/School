using System;
using System.Text.RegularExpressions;

namespace Extract_emails
{
    public class ExtractEmails
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var pattern = @"(?<=\s)[a-zA-Z0-9]+[._\-a-zA-Z0-9]*@[a-zA-Z]+([-.][a-zA-Z]+)*\.[a-z]{2,}";
            var regex = new Regex(pattern);

            var matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
