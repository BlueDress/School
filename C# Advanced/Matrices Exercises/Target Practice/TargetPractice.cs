using System;
using System.Linq;
using System.Text;

namespace Target_Practice
{
    public class TargetPractice
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();
            var rows = int.Parse(input[0]);
            var cols = int.Parse(input[1]);

            var matrix = new char[rows][];

            var snake = Console.ReadLine().ToCharArray();
            var snakeCharIndex = 0;
            var direction = "left";

            for (int row = matrix.Length - 1; row >= 0; row--)
            {
                matrix[row] = new char[cols];

                if (direction.Equals("left"))
                {
                    for (int col = matrix[row].Length - 1; col  >= 0;  col --)
                    {
                        matrix[row][col] = snake[snakeCharIndex % snake.Length];
                        snakeCharIndex++;
                    }

                    direction = "right";
                }
                else
                {
                    for (int col = 0; col < matrix[row].Length; col++)
                    {
                        matrix[row][col] = snake[snakeCharIndex % snake.Length];
                        snakeCharIndex++;
                    }

                    direction = "left";
                }
            }

            var shotParameters = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var impactRow = shotParameters[0];
            var impactCol = shotParameters[1];
            var radius = shotParameters[2];
            var radiusDecline = 0;

            for (int i = 0; i <= radius; i++)
            {
                for (int row = impactRow; row <= impactRow + radius; row++)
                {
                    for (int col = impactCol - radius + radiusDecline; col <= impactCol + radius - radiusDecline; col++)
                    {
                        matrix[row][col] = ' ';
                    }

                    radiusDecline++;
                }
            }

            radiusDecline = 1;

            for (int i = 1; i <= radius; i++)
            {
                for (int row = impactRow - 1; row >= impactRow - radius; row--)
                {
                    for (int col = impactCol - radius + radiusDecline; col <= impactCol + radius - radiusDecline; col++)
                    {
                        matrix[row][col] = ' ';
                    }

                    radiusDecline++;
                }
            }

            for (int col = 0; col < cols; col++)
            {
                var spaces = new StringBuilder();
                var chars = new StringBuilder();

                for (int row = 0; row < matrix.Length; row++)
                {
                    if (matrix[row][col].Equals(' '))
                    {
                        spaces.Append(matrix[row][col]);
                    }
                    else
                    {
                        chars.Append(matrix[row][col]);
                    }
                }

                var newCol = spaces.Append(chars).ToString().ToCharArray();

                for (int row = 0; row < matrix.Length; row++)
                {
                    matrix[row][col] = newCol[row];
                }
            }

            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
