using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Real_Numbers
{
    public class CountRealNumbers
    {
        public static void Main()
        {
            List<double> inputNumbers = Console.ReadLine().Split().Select(double.Parse).ToList();

            var result = new SortedDictionary<double, int>();

            foreach (var number in inputNumbers)
            {
                if (!result.ContainsKey(number))
                {
                    result[number] = 0;
                }
                result[number]++;
            }
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} -> {item.Value} times");
            }
        }
    }
}
