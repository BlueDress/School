using System;
using System.Text;

namespace Matrix_of_Palindromes
{
    public class MatrixOfPalindromes
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();
            var rows = int.Parse(input[0]);
            var cols = int.Parse(input[1]);

            var matrix = new string[rows][];

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = new string[cols];

                for (int col = 0; col < cols; col++)
                {
                    var sb = new StringBuilder();

                    sb.Append((char)('a' + row));
                    sb.Append((char)('a' + col + row));
                    sb.Append((char)('a' + row));

                    matrix[row][col] = sb.ToString();
                }
            }

            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
