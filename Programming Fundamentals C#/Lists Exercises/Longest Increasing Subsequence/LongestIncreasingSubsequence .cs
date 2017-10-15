using System;
using System.Collections.Generic;
using System.Linq;

namespace Longest_Increasing_Subsequence
{
    public class Program
    {
        public static void Main()
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            var length = new int[input.Count];
            var prev = new int[input.Count];
            length[0] = 1;
            prev[0] = -1;

            var maxCount = 0;
            var lastIndex = -1;
            for (int i = 1; i < length.Length; i++)
            {
                length[i] = 1;
                prev[i] = -1;

                for (int j = 0; j < i; j++)
                {
                    if (input[i] > input[j] && length[i] == length[j])
                    {
                        length[i]++;
                        prev[i] = j;
                    }
                }

                if (maxCount < length[i])
                {
                    maxCount = length[i];
                    lastIndex = i;
                }
            }

            var output = new List<int>();

            for (int i = 0; i < maxCount; i++)
            {
                output.Add(input[lastIndex]);
                lastIndex = prev[lastIndex];
            }
            output.Reverse();

            if (output.Count > 0)
            {
                Console.WriteLine(string.Join(" ", output));
            }
            else
            {
                Console.WriteLine(input[0]);
            }
        }
    }
}
