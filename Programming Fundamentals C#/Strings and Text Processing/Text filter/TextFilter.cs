using System;
using System.Linq;

namespace Text_filter
{
    public class TextFilter
    {
        public static void Main()
        {
            var bannedWords = Console.ReadLine().ToLower().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var input = Console.ReadLine().ToLower();

            foreach (var word in bannedWords)
            {
                input = input.Replace(word, new string('*', word.Length));
            }

            Console.WriteLine(input);
        }
    }
}
