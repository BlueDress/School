using System;
using System.Collections.Generic;
using System.Linq;

namespace Odd_Occurrences
{
    public class OddOccurrences
    {
        public static void Main()
        {
            var inputWords = Console.ReadLine().ToLower().Split().ToList();

            var resultDict = new Dictionary<string, int>();

            foreach (var word in inputWords)
            {
                if (!resultDict.ContainsKey(word))
                {
                    resultDict[word] = 0;
                }
                resultDict[word]++;
            }
            var result = new List<string>();
            foreach (var item in resultDict)
            {
                if (item.Value % 2 != 0)
                {
                    result.Add(item.Key);
                }
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
