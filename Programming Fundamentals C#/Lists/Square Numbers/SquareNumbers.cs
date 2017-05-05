using System;
using System.Collections.Generic;
using System.Linq;

namespace Square_Numbers
{
    public class SquareNumbers
    {
        public static void Main()
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            var output = new List<int>();

            for (int item = 0; item < input.Count; item++)
            {
                if (Math.Sqrt(input[item]) % 1 == 0)
                {
                    output.Add(input[item]);
                }
            }
            output.Sort();
            output.Reverse();
            Console.WriteLine(string.Join(" ", output));
        }
    }
}
