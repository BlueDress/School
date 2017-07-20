using System;
using System.Text.RegularExpressions;

namespace Match_Phone_Number
{
    public class MatchPhoneNumber
    {
        public static void Main()
        {
            var pattern = @"^\+359( |-)2\1\d{3}\1\d{4}$";
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
