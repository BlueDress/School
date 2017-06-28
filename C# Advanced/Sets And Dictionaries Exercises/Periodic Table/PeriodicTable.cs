using System;
using System.Collections.Generic;

namespace Periodic_Table
{
    public class PeriodicTable
    {
        public static void Main()
        {
            var numberOfCompounds = int.Parse(Console.ReadLine());
            var compounds = new SortedSet<string>();

            for (int i = 0; i < numberOfCompounds; i++)
            {
                var elements = Console.ReadLine().Split();

                foreach (var element in elements)
                {
                    compounds.Add(element);
                }
            }

            Console.WriteLine(string.Join(" ", compounds));
        }
    }
}
