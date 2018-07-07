using System;
using System.Collections.Generic;
using System.Linq;

namespace Ch09P13
{
    public class Startup
    {
        public static void Main()
        {
            int[] firstPolynomialCoefficients = Console.ReadLine().Split().Select(int.Parse).Reverse().ToArray();
            int[] secondPolynomialCoefficients = Console.ReadLine().Split().Select(int.Parse).Reverse().ToArray();

            int[] result = MultiplyPolinomials(firstPolynomialCoefficients, secondPolynomialCoefficients);

            for (int i = result.Length - 1; i >= 0; i--)
            {
                if (result[i] != 0)
                {
                    Console.Write($"{result[i]}x{i} ");
                }
            }

            Console.WriteLine();
        }

        private static int[] MultiplyPolinomials(int[] firstPolynomialCoefficients, int[] secondPolynomialCoefficients)
        {
            int[] result = new int[Math.Max(firstPolynomialCoefficients.Length, secondPolynomialCoefficients.Length) + 1];

            for (int i = 0; i < firstPolynomialCoefficients.Length; i++)
            {
                for (int j = 0; j < secondPolynomialCoefficients.Length; j++)
                {
                    result[i + j] += firstPolynomialCoefficients[i] * secondPolynomialCoefficients[j]; 
                }
            }

            return result;
        }
    }
}
