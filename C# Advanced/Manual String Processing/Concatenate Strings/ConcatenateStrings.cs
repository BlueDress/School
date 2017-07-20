using System;
using System.Text;

namespace Concatenate_Strings
{
    public class ConcatenateStrings
    {
        public static void Main()
        {
            var numberOfWords = int.Parse(Console.ReadLine());

            var sb = new StringBuilder();

            for (int word = 0; word < numberOfWords; word++)
            {
                var inputWord = Console.ReadLine();
                sb.Append(inputWord);
                sb.Append(" ");
            }

            Console.WriteLine(sb.ToString().Trim());
        }
    }
}
