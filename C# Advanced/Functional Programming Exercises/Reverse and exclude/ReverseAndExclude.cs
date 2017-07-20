using System;
using System.Linq;

namespace Reverse_and_exclude
{
    public class ReverseAndExclude
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var divisor = int.Parse(Console.ReadLine());

            ReverseElements(numbers);

            Predicate<int> SelectDivisibleElements = x => x % divisor == 0;

            Console.WriteLine(string.Join(" ", numbers.Where(x => !SelectDivisibleElements(x)).ToArray())); 
        }

        private static void ReverseElements(int[] numbers)
        {
            var reversedElements = new int[numbers.Length];

            for (int i = numbers.Length - 1; i >= 0 ; i--)
            {
                reversedElements[numbers.Length - 1 - i] = numbers[i];
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = reversedElements[i];
            }
        }
    }
}
