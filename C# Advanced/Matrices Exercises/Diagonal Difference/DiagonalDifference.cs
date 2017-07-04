using System;
using System.Linq;

namespace Diagonal_Difference
{
    public class DiagonalDifference
    {
        public static void Main()
        {
            var rows = int.Parse(Console.ReadLine());

            var matrix = new int[rows][];

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }

            var leftDiagonalSum = 0;

            for (int i = 0; i < matrix.Length; i++)
            {
                leftDiagonalSum += matrix[i][i];
            }

            var rightDiagonalSum = 0;

            for (int i = matrix.Length - 1; i >= 0; i--)
            {
                rightDiagonalSum += matrix[i][matrix.Length - 1 - i];
            }

            var difference = Math.Abs(leftDiagonalSum - rightDiagonalSum);
            Console.WriteLine(difference);
        }
    }
}
