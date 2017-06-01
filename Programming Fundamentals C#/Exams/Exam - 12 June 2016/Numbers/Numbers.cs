using System;
using System.Collections.Generic;
using System.Linq;

namespace Numbers
{
    public class Numbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            var averageValue = numbers.Average();

            var numbersGraeterThanAverageValue = new List<int>();

            foreach (var number in numbers)
            {
                if (number > averageValue)
                {
                    numbersGraeterThanAverageValue.Add(number);
                }
            }

            if (numbersGraeterThanAverageValue.Count > 0)
            {
                var result = string.Join(" ", numbersGraeterThanAverageValue.OrderByDescending(x => x).Take(5));
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
