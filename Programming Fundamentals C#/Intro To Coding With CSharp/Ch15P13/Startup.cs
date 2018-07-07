using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Ch15P13
{
    public class Startup
    {
        public static void Main()
        {
            StreamReader sr = new StreamReader("words.txt");

            Dictionary<string, int> wordsCount = new Dictionary<string, int>();
            List<string> words = new List<string>();

            using (sr)
            {
                while (true)
                {
                    string line = sr.ReadLine();

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
                    string line = sr.ReadLine();

                    if (line == null)
                    {
                        break;
                    }

                    foreach (string word in words)
                    {
                        string pattern = $@"\b{word.ToLower()}\b";
                        MatchCollection matches = Regex.Matches(line.ToLower(), pattern);
                        wordsCount[word] += matches.Count;
                    }
                }
            }

            var sortedWords = wordsCount.OrderByDescending(x => x.Value);

            StreamWriter sw = new StreamWriter("result.txt");

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
