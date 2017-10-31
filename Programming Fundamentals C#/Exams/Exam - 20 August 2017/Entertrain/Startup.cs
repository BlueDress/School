using System;
using System.Collections.Generic;
using System.Linq;

namespace Entertrain
{
    public class Startup
    {
        public static void Main()
        {
            var locomotivePower = int.Parse(Console.ReadLine());
            var wagons = new List<int>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input.Equals("All ofboard!"))
                {
                    break;
                }

                var wagonWeight = int.Parse(input);
                wagons.Add(wagonWeight);

                if (wagons.Sum() > locomotivePower)
                {
                    var averageWeight = wagons.Sum() / wagons.Count;

                    var minDifference = int.MaxValue;
                    var indexToRemoveAt = -1;

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        var currentDifference = Math.Abs(averageWeight - wagons[i]);

                        if (currentDifference < minDifference)
                        {
                            minDifference = currentDifference;
                            indexToRemoveAt = i;
                        }
                    }

                    wagons.RemoveAt(indexToRemoveAt);
                }
            }

            wagons.Insert(0, locomotivePower);
            wagons.Reverse();
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
