using System;
using System.Text.RegularExpressions;

namespace Regexmon
{
    public class Startup
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var bojomonPattern = @"[a-zA-Z]+-[a-zA-Z]+";
            var didimonPattern = @"[^a-zA-Z-]+";
            var didisTurn = true;
            var match = string.Empty;

            while (true)
            {
                if (didisTurn)
                {
                    match = Regex.Match(input, didimonPattern).ToString();
                    didisTurn = false;
                }
                else
                {
                    match = Regex.Match(input, bojomonPattern).ToString();
                    didisTurn = true;
                }

                if (match.Equals(string.Empty))
                {
                    break;
                }

                Console.WriteLine(match);

                input = input.Substring(input.IndexOf(match) + match.Length);
            }
        }
    }
}
