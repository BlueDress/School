using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Phoenix_Grid
{
    public class Startup
    {
        public static void Main()
        {
            var pattern = @"^([^\s_]{3})(\.[^\s_]{3})*$";

            while (true)
            {
                var message = Console.ReadLine();

                if (message.Equals("ReadMe"))
                {
                    break;
                }

                if (Regex.IsMatch(message, pattern) && IsPalindrome(message))
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }

        public static bool IsPalindrome(string word)
        {
            var reversedString = string.Join("", word.Reverse());

            if (word.Equals(reversedString))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
