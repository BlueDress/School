using System;

namespace _2x2_Squares_in_Matrix
{
    public class SquaresInMatrix
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();
            var rows = int.Parse(input[0]);
            var cols = int.Parse(input[1]);

            var matrix = new string[rows][];

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = Console.ReadLine().Split();
            }

            var numberOfSquareMatrixes = 0;

            for (int row = 0; row < matrix.Length - 1; row++)
            {
                for (int col = 0; col < matrix[row].Length - 1; col++)
                {
                    if (matrix[row][col].Equals(matrix[row][col + 1]) && matrix[row][col].Equals(matrix[row + 1][col]) && matrix[row][col].Equals(matrix[row + 1][col + 1]))
                    {
                        numberOfSquareMatrixes++;
                    }
                }
            }

            Console.WriteLine(numberOfSquareMatrixes);
        }
    }
}
