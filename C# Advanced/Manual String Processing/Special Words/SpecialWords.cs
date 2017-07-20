using System;
using System.Collections.Generic;

namespace Special_Words
{
    public class SpecialWords
    {
        public static void Main()
        {
            var inputSpecialWords = Console.ReadLine().Split();
            var specialWords = new Dictionary<string, int>();

            for (int i = 0; i < inputSpecialWords.Length; i++)
            {
                specialWords[inputSpecialWords[i]] = 0;
            }

            var inputText = Console.ReadLine().Split(new[] { '(', ')', '[', ']', '<', '>', ',', '-', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < inputText.Length; i++)
            {
                for (int j = 0; j < inputSpecialWords.Length; j++)
                {
                    if (inputText[i].Equals(inputSpecialWords[j]))
                    {
                        specialWords[inputText[i]]++;
                        break;
                    }
                }
            }

            foreach (var word in specialWords)
            {
                Console.WriteLine($"{word.Key} - {word.Value}");
            }
        }
    }
}
