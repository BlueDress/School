using System;
using System.Text.RegularExpressions;

namespace Vowel_Count
{
    public class VowelCount
    {
        public static void Main()
        {
            var pattern = "[aeoiuyAEOIUY]";
            var text = Console.ReadLine();

            var regex = new Regex(pattern);
            var matches = regex.Matches(text);

            Console.WriteLine($"Vowels: {matches.Count}");
        }
    }
}
