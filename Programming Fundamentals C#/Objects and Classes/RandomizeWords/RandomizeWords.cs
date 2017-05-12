using System;
using System.Linq;

namespace RandomizeWords
{
    public class RandomizeWords
    {
        public static void Main()
        {
            var inputWords = Console.ReadLine().Split().ToList();

            for (int i = 0; i < inputWords.Count; i++)
            {
                var tempWord = inputWords[i];
                var randomNumber = new Random().Next(0, inputWords.Count);
                inputWords[i] = inputWords[randomNumber];
                inputWords[randomNumber] = tempWord;
            }

            foreach (var word in inputWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}
