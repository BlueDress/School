using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Word_Count
{
    public class WordCount
    {
        public static void Main()
        {
            var words = File.ReadAllText("words.txt").ToLower().Split();
            var input = File.ReadAllText("Input.txt").ToLower().Split(new[] { ' ', '-', '.', ',', '\n', '\r', '\'', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);

            var output = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if (words[i].Equals(input[j]))
                    {
                        if (!output.ContainsKey(words[i]))
                        {
                            output[words[i]] = 0;
                        }
                        output[words[i]]++;
                    }
                }
            }

            foreach (var word in output.OrderByDescending(x => x.Value))
            {
                File.AppendAllText("output.txt", word.Key + " - " + word.Value + Environment.NewLine);
            }
        }
    }
}
