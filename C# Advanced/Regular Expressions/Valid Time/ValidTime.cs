using System;
using System.Text.RegularExpressions;

namespace Valid_Time
{
    public class ValidTime
    {
        public static void Main()
        {
            var pattern = @"([0][0-9]|[1][01]):[0-5][0-9]:[0-5][0-9]\s(A|P)M";
            var regex = new Regex(pattern);

            while (true)
            {
                var input = Console.ReadLine();

                if (input.Equals("END"))
                {
                    break;
                }
                else
                {
                    var match = regex.Match(input);

                    if (match.Success)
                    {
                        Console.WriteLine("valid");
                    }
                    else
                    {
                        Console.WriteLine("invalid");
                    }
                }
            }
        }
    }
}
