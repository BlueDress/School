using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Numbers
{
    public class CountNumbers
    {
        public static void Main()
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            var output = new int[1001];

            for (int item = 0; item < input.Count; item++)
            {
                output[input[item]]++;
            }
            for (int index = 0; index < output.Length; index++)
            {
                if (output[index] > 0)
                {
                Console.WriteLine($"{index} -> {output[index]}");
                }
            }
        }
    }
}
