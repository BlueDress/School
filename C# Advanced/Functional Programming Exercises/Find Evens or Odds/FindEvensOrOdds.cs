using System;
using System.Collections.Generic;
using System.Linq;

namespace Find_Evens_or_Odds
{
    public class FindEvensOrOdds
    {
        public static void Main()
        {
            var tokens = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var startNumber = tokens[0];
            var endNumber = tokens[1];

            var command = Console.ReadLine();

            Predicate<int> EvenCheck = x => x % 2 == 0;

            var result = new List<int>();

            for (int i = startNumber; i <= endNumber; i++)
            {
                if (command.Equals("even"))
                {
                    if (EvenCheck(i))
                    {
                        result.Add(i);
                    }
                }
                else
                {
                    if (!EvenCheck(i))
                    {
                        result.Add(i);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
