using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace WordCount
{
    public class Startup
    {
        public static void Main()
        {
            var sr = new StreamReader("words.txt");

            var wordsCount = new Dictionary<string, int>();
            var words = new List<string>();

            using (sr)
            {
                while (true)
                {
                    var line = sr.ReadLine();

                    if (line == null)
                    {
                        break;
                    }

                    wordsCount[line] = 0;
                    words.Add(line);
                }
            }

            sr = new StreamReader("text.txt");

            using (sr)
            {
                while (true)
                {
                    var line = sr.ReadLine();

                    if (line == null)
                    {
                        break;
                    }

                    foreach (var word in words)
                    {
                        var pattern = $@"\b{word.ToLower()}\b";
                        var matches = Regex.Matches(line.ToLower(), pattern);
                        wordsCount[word] += matches.Count;
                    }
                }
            }

            var sortedWords = wordsCount.OrderByDescending(x => x.Value);

            var sw = new StreamWriter("result.txt");

            using (sw)
            {
                foreach (var kvp in sortedWords)
                {
                    sw.WriteLine($"{kvp.Key} - {kvp.Value}");
                }
            }
        }
    }
}
