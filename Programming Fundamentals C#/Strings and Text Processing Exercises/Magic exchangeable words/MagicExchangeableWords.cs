using System;
using System.Collections.Generic;

namespace Magic_exchangeable_words
{
    public class MagicExchangeableWords
    {
        public static bool AreWordsMagic(string firstString, string secondString)
        {
            var firstStringHashSet = new HashSet<char>(firstString);
            var secondStringHashSet = new HashSet<char>(secondString);

            if (firstStringHashSet.Count == secondStringHashSet.Count)
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
            var input = Console.ReadLine().Split();

            var result = AreWordsMagic(input[0], input[1]).ToString().ToLower();

            Console.WriteLine(result);
        }
    }
}
