using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Palindromes
{
    public class Palindromes
    {
        public static bool IsPalindrome(string input)
        {
            var reversedInput = input.Reverse();

            var result = new StringBuilder();

            foreach (var item in reversedInput)
            {
                result = result.Append(item);
            }

            var reversedString = result.ToString();

            if (input == reversedString)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void Main()
        {
            var input = Console.ReadLine().Split(new[] { ' ', '.', '!', '?', ',' }, StringSplitOptions.RemoveEmptyEntries);

            var palindromes = new List<string>();

            foreach (var word in input)
            {
                if (IsPalindrome(word) && !palindromes.Contains(word))
                {
                    palindromes.Add(word);
                }
            }

            Console.WriteLine(string.Join(", ", palindromes.OrderBy(x => x)));
        }
    }
}
