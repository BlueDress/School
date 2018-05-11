using System;
using System.Linq;

namespace RecursiveArraySum
{
    public class Startup
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var sum = GetSum(numbers, 0);

            Console.WriteLine(sum);
        }

        private static int GetSum(int[] numbers, int index)
        {
            if (index == numbers.Length - 1)
            {
                return numbers[index];
            }

            return numbers[index] + GetSum(numbers, ++index);
        }
    }
}
