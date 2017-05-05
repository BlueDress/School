using System;
using System.Collections.Generic;
using System.Linq;

namespace Sum_Adjacent_Equal_Numbers
{
    public class SumAdjacentEqualNumbers
    {
        public static void Main()
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int element = 1; element < input.Count; element++)
            {
                if (input[element] == input[element - 1])

                {
                    var tempSum = input[element] + input[element - 1];
                    input.RemoveAt(element);
                    input[element - 1] = tempSum;
                    element = 0;
                }

            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
