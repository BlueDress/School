using System;

namespace Recursive_Fibonacci
{
    public class RecursiveFibonacci
    {
        private static int[] numbers;

        public static void Main()
        {
            var nthNumber = int.Parse(Console.ReadLine());
            numbers = new int[nthNumber];
            var result = GetFibonacciNumber(nthNumber);
            Console.WriteLine(result);
        }

        private static int GetFibonacciNumber(int nthNumber)
        {
            if (nthNumber <= 2)
            {
                return numbers[nthNumber - 1] = 1;
            }

            if (numbers[nthNumber - 1] != 0)
            {
                return numbers[nthNumber - 1];
            }
            return numbers[nthNumber - 1] = GetFibonacciNumber(nthNumber - 1) + GetFibonacciNumber(nthNumber - 2);
        }
    }
}
