using System;
using System.Collections.Generic;
using System.Linq;

namespace List_of_Predicates
{
    public class ListOfPredicates
    {
        public static void Main()
        {
            var endRange = int.Parse(Console.ReadLine());
            var divisors = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Func<int, int, bool> IsDivisible = (n, d) => n % d == 0;

            var result = new List<int>();

            for (int number = 1; number <= endRange; number++)
            {
                var MeetsTheConditions = true;

                for (int divisor = 0; divisor < divisors.Length; divisor++)
                {
                    if (!IsDivisible(number, divisors[divisor]))
                    {
                        MeetsTheConditions = false;
                    }
                }

                if (MeetsTheConditions)
                {
                    result.Add(number);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
