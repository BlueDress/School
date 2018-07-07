using System;
using System.Collections.Generic;
using System.Linq;

namespace Ch18P02
{
    public class Startup
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            Dictionary<int, int> numbersCount = new Dictionary<int, int>();

            foreach (int number in numbers)
            {
                if (!numbersCount.ContainsKey(number))
                {
                    numbersCount[number] = 0;
                }

                numbersCount[number]++;
            }

            Console.WriteLine(string.Join(", ", numbers.Where(n => numbersCount[n] % 2 == 0)));
        }
    }
}
