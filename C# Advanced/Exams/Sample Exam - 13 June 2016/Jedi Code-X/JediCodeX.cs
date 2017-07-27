using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Jedi_Code_X
{
    public class JediCodeX
    {
        public static void Main()
        {
            var numberOfEntries = int.Parse(Console.ReadLine());

            var sb = new StringBuilder();

            for (int i = 0; i < numberOfEntries; i++)
            {
                sb.Append(Console.ReadLine());
            }

            var encodedText = sb.ToString();

            var namePattern = Console.ReadLine();
            var messagePattern = Console.ReadLine();
            var nameExtractor = $"{namePattern}[a-zA-Z]+";
            var messageExtractor = $"{messagePattern}[a-zA-Z0-9]+";

            var nameMatches = Regex.Matches(encodedText, nameExtractor);
            var jediNames = new List<string>();

            foreach (var match in nameMatches)
            {
                if (match.ToString().Length == 2 * namePattern.Length)
                {
                    jediNames.Add(string.Join("", match.ToString().Skip(namePattern.Length)));
                }
            }

            var messageMaches = Regex.Matches(encodedText, messageExtractor);
            var messages = new List<string>();

            foreach (var match in messageMaches)
            {
                if (match.ToString().Length == 2 * messagePattern.Length)
                {
                    messages.Add(string.Join("", match.ToString().Skip(messagePattern.Length)));
                }
            }

            var indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var noMoreIndexes = false;
            var startIndex = 0;

            for (int i = 0; i < jediNames.Count; i++)
            {
                for (int j = startIndex; j < indexes.Count(); j++)
                {
                    var index = indexes[j];
                    if (index <= messages.Count)
                    {
                        Console.WriteLine($"{jediNames[i]} - {messages[index - 1]}");
                        startIndex = j + 1;

                        if (startIndex == indexes.Count())
                        {
                            noMoreIndexes = true;
                        }
                        break;
                    }
                }

                if (noMoreIndexes)
                {
                    break;
                }
            }
        }
    }
}
