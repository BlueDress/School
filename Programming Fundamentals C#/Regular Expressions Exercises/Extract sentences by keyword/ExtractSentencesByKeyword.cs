using System;
using System.Text.RegularExpressions;

namespace Extract_sentences_by_keyword
{
    public class ExtractSentencesByKeyword
    {
        public static void Main()
        {
            var keyWord = Console.ReadLine();
            var input = Console.ReadLine();

            var pattern = $@"[^.!?]*\b{keyWord}\b[^.!?]*";
            var regex = new Regex(pattern);

            var matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.ToString().Trim());
            }
        }
    }
}
