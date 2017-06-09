using System;
using System.Collections.Generic;
using System.Linq;

namespace Worm_Ipsum
{
    public class WormIpsum
    {
        public static void Main()
        {
            while (true)
            {
                var input = Console.ReadLine();

                if (input.Equals("Worm Ipsum"))
                {
                    break;
                }
                else
                {
                    var sentences = input.Split(new[] { '.' }, StringSplitOptions.RemoveEmptyEntries);

                    if (sentences.Length == 1)
                    {
                        var words = sentences[0].Split(new[] { ' ', ',', '-', '"', '\'', '>', '<' }, StringSplitOptions.RemoveEmptyEntries);

                        var processedSentence = new string[words.Length];

                        for (int i = 0; i < words.Length; i++)
                        {
                            var wordChars = new Dictionary<char, int>();

                            foreach (var symbol in words[i])
                            {
                                if (!wordChars.ContainsKey(symbol))
                                {
                                    wordChars[symbol] = 0;
                                }

                                wordChars[symbol]++;
                            }

                            if (wordChars.Count == words[i].Length)
                            {
                                processedSentence[i] = words[i];
                            }
                            else
                            {
                                var mostCommonCharKVP = wordChars.OrderByDescending(x => x.Value).ElementAt(0);
                                var mostCommonChar = mostCommonCharKVP.Key;
                                processedSentence[i] = new string(mostCommonChar, words[i].Length);
                            }
                        }

                        Console.WriteLine($"{string.Join(" ", processedSentence)}.");
                    }
                }
            }
        }
    }
}
