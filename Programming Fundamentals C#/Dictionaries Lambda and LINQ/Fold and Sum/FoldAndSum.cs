using System;
using System.Collections.Generic;
using System.Linq;

namespace Fold_and_Sum
{
    public class FoldAndSum
    {
        public static void Main()
        {
            var inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var lenght = inputNumbers.Count;

            var leftFold = inputNumbers.Take(lenght / 4).Reverse().ToList();
            var rightFold = inputNumbers.Skip(lenght / 4 * 3).Reverse().ToList();

            var firstRow = leftFold.Concat(rightFold).ToList();
            var secondRow = inputNumbers.Skip(lenght / 4).Take(lenght / 2).ToList();

            var sum = new int[lenght / 2];

            for (int index = 0; index < lenght / 2; index++)
            {
                sum[index] = firstRow[index] + secondRow[index];
            }
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
