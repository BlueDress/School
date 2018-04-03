using System;
using System.Collections.Generic;
using System.Linq;

namespace LongestSubsequence
{
    public class Startup
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            var longestRepeatedElement = numbers[0];
            var longestSubsequenceCount = 1;

            for (int i = 0; i < numbers.Count; i++)
            {
                var currentSubsequenceCount = 1;
                var currentElement = numbers[i];

                for (int j = i + 1; j < numbers.Count; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        currentSubsequenceCount++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (longestSubsequenceCount < currentSubsequenceCount)
                {
                    longestSubsequenceCount = currentSubsequenceCount;
                    longestRepeatedElement = currentElement;
                }

                i += currentSubsequenceCount - 1;

                if (longestSubsequenceCount >= numbers.Count - i - 1)
                {
                    break;
                }
            }

            var longestSubsequence = new List<int>();

            for (int i = 0; i < longestSubsequenceCount; i++)
            {
                longestSubsequence.Add(longestRepeatedElement);
            }

            Console.WriteLine(string.Join(" ", longestSubsequence));
        }
    }
}
