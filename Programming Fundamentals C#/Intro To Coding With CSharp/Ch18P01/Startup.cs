using System;
using System.Collections.Generic;
using System.Linq;

namespace Ch18P01
{
    public class Startup
    {
        public static void Main()
        {
            int[] inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            SortedDictionary<int, int> result = new SortedDictionary<int, int>();

            foreach (int number in inputNumbers)
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
