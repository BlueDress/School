using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveOddOccurrences
{
    public class Startup
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var numbersOccurrences = new Dictionary<int, int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (!numbersOccurrences.ContainsKey(numbers[i]))
                {
                    numbersOccurrences[numbers[i]] = 0;
                }

                numbersOccurrences[numbers[i]]++;
            }

            var numbersWithEvenOccurrences = numbersOccurrences.Where(x => x.Value % 2 == 0).ToDictionary(x => x.Key);

            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                if (!numbersWithEvenOccurrences.ContainsKey(numbers[i]))
                {
                    numbers.RemoveAt(i);
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
