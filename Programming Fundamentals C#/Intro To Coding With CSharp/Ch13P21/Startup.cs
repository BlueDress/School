using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch13P21
{
    public class Startup
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(new[] { ' ', '.', '!', '?', ',' }, StringSplitOptions.RemoveEmptyEntries);

            List<string> palindromes = new List<string>();

            foreach (string word in input)
            {
                if (IsPalindrome(word) && !palindromes.Contains(word))
                {
                    palindromes.Add(word);
                }
            }

            Console.WriteLine(string.Join(", ", palindromes));
        }

        private static bool IsPalindrome(string input)
        {
            char[] reversedInput = input.Reverse().ToArray();

            StringBuilder result = new StringBuilder();

            foreach (char item in reversedInput)
            {
                result = result.Append(item);
            }

            string reversedString = result.ToString();

            if (input == reversedString)
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
