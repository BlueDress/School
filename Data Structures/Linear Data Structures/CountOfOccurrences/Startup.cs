using System;
using System.Linq;

namespace CountOfOccurrences
{
    public class Startup
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            var numberOccurrences = new int[1001];

            for (int i = 0; i < numbers.Count; i++)
            {
                numberOccurrences[numbers[i]]++;
            }

            for (int i = 0; i < numberOccurrences.Length; i++)
            {
                if (numberOccurrences[i] > 0)
                {
                    Console.WriteLine($"{i} -> {numberOccurrences[i]} times");
                }
            }
        }
    }
}
