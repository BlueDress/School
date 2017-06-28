using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Same_Values_in_Array
{
    public class CountSameValuesInArray
    {
        public static void Main()
        {
            var arrayOfNumbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            var sameValuesCount = new SortedDictionary<double, int>();

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                if (!sameValuesCount.ContainsKey(arrayOfNumbers[i]))
                {
                    sameValuesCount[arrayOfNumbers[i]] = 0;
                }

                sameValuesCount[arrayOfNumbers[i]]++;
            }

            foreach (var value in sameValuesCount)
            {
                Console.WriteLine($"{value.Key} - {value.Value} times");
            }
        }
    }
}
