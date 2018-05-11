using System;
using System.Linq;

namespace GeneratingCombinations
{
    public class Startup
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var numberOfElements = int.Parse(Console.ReadLine());
            var vector = new int[numberOfElements];

            PrintCombinations(numbers, vector, 0, 0);
        }

        private static void PrintCombinations(int[] numbers, int[] vector, int index, int border)
        {
            if (index > vector.Length - 1)
            {
                Console.WriteLine(string.Join("", vector));
                return;
            }

            for (int i = border; i < numbers.Length; i++)
            {
                vector[index] = numbers[i];
                PrintCombinations(numbers, vector, index + 1, i + 1);
            }
        }
    }
}
