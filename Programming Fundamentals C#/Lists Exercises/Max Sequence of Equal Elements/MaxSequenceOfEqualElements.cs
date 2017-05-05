using System;
using System.Collections.Generic;
using System.Linq;

namespace Max_Sequence_of_Equal_Elements
{
    public class MaxSequenceOfEqualElements
    {
        public static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();

            var count = 1;
            var maxCount = 0;
            var equalElement = string.Empty;

            for (int item = 0; item < input.Count - 1; item++)
            {
                if (input[item] == input[item + 1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }

                if (maxCount < count)
                {
                    maxCount = count;
                    equalElement = input[item];
                }
            }

            for (int i = 0; i < maxCount; i++)
            {
                Console.Write(equalElement + " ");
            }
            Console.WriteLine();
        }
    }
}
