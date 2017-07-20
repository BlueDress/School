using System;
using System.Text.RegularExpressions;

namespace Valid_Usernames
{
    public class ValidUsernames
    {
        public static void Main()
        {
            var pattern = @"^[\w-]{3,16}$";
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
