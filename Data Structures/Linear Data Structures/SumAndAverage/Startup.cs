using System;
using System.Collections.Generic;
using System.Linq;

namespace SumAndAverage
{
    public class Startup
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var numbers = new List<int>();

            if (!string.IsNullOrEmpty(input) && !string.IsNullOrWhiteSpace(input))
            {
                numbers = input.Split().Select(int.Parse).ToList();
            }
            else
            {
                numbers.Add(0);
            }

            var sum = numbers.Sum();
            var average = numbers.Average();

            Console.WriteLine($"Sum={sum}; Average={average:f2}");
        }
    }
}
