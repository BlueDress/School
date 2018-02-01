using System;
using System.Linq;

namespace Maximal_Sum
{
    public class MaximalSum
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();
            var rows = int.Parse(input[0]);
            var cols = int.Parse(input[1]);

            var matrix = new int[rows][];

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }

            var maxSum = int.MinValue;
            var topLeftElementRow = 0;
            var topLeftElementCol = 0;

            for (int row = 0; row < matrix.Length - 2; row++)
            {
                for (int col = 0; col < matrix[row].Length - 2; col++)
                {
                    var currentSum = matrix[row][col] + matrix[row][col + 1] + matrix[row][col + 2] + matrix[row + 1][col] + matrix[row + 1][col + 1] + matrix[row + 1][col + 2] + matrix[row + 2][col] + matrix[row + 2][col + 1] + matrix[row + 2][col + 2];
                    if (maxSum < currentSum)
                    {
                        maxSum = currentSum;
                        topLeftElementRow = row;
                        topLeftElementCol = col;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");

            for (int row = topLeftElementRow; row < topLeftElementRow + 3; row++)
            {
                for (int col = topLeftElementCol; col < topLeftElementCol + 3; col++)
                {
                    Console.Write($"{matrix[row][col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
