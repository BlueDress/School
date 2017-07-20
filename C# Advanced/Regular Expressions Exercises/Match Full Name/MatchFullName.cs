using System;
using System.Text.RegularExpressions;

namespace Match_Full_Name
{
    public class MatchFullName
    {
        public static void Main()
        {
            var pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            var regex = new Regex(pattern);

            while (true)
            {
                var input = Console.ReadLine();

                if (input.Equals("end"))
                {
                    break;
                }
                else
                {
                    var match = regex.Match(input);

                    if (match.Success)
                    {
                        Console.WriteLine(match);
                    }
                }
            }
        }
    }
}
