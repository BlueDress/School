using System;
using System.Linq;

namespace Rotate_and_Sum
{
    class RotateAndSum
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var numberOfRotations = int.Parse(Console.ReadLine());

            var sum = new long[input.Length];

            for (int i = 0; i < numberOfRotations; i++)
            {
                var lastElement = input[input.Length - 1];

                for (int j = input.Length - 1; j > 0; j--)
                {
                    input[j] = input[j - 1];
                    sum[j] += input[j];
                }

                input[0] = lastElement;
                sum[0] += input[0];
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
