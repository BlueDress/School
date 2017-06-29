using System;
using System.Linq;

namespace Maximum_sum_of_2x2_submatrix
{
    public class MaximumSumOf2x2Submatrix
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var rows = input[0];
            var cols = input[1];

            var matrix = new int[rows][];
            var maxSum = int.MinValue;
            var topLeftRow = 0;
            var topLeftCol = 0;

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }

            for (int row = 0; row < matrix.Length - 1; row++)
            {
                for (int col = 0; col < matrix[row].Length - 1; col++)
                {
                    var currentSum = matrix[row][col] + matrix[row][col + 1] + matrix[row + 1][col] + matrix[row + 1][col + 1];

                    if (maxSum < currentSum)
                    {
                        maxSum = currentSum;
                        topLeftRow = row;
                        topLeftCol = col;
                    }
                }
            }

            Console.WriteLine($"{matrix[topLeftRow][topLeftCol]} {matrix[topLeftRow][topLeftCol + 1]}\n{matrix[topLeftRow + 1][topLeftCol]} {matrix[topLeftRow + 1][topLeftCol + 1]}\n{maxSum}");
        }
    }
}
