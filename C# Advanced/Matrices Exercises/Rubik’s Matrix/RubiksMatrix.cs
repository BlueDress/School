using System;

namespace Rubik_s_Matrix
{
    public class RubiksMatrix
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();
            var rows = int.Parse(input[0]);
            var cols = int.Parse(input[1]);

            var matrix = new int[rows][];
            var counter = 1;

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = new int[cols];

                for (int col = 0; col < matrix[row].Length; col++)
                {
                    matrix[row][col] = counter;
                    counter++;
                }
            }

            var numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                var commands = Console.ReadLine();
                matrix = ShufflingMatrix(matrix, commands);

            }

            counter = 1;

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row][col] == counter)
                    {
                        Console.WriteLine("No swap required");
                    }
                    else
                    {
                        for (int rowSwap = 0; rowSwap < matrix.Length; rowSwap++)
                        {
                            for (int colSwap = 0; colSwap < matrix[rowSwap].Length; colSwap++)
                            {
                                if (matrix[rowSwap][colSwap] == counter)
                                {
                                    var tempCell = matrix[rowSwap][colSwap];
                                    matrix[rowSwap][colSwap] = matrix[row][col];
                                    matrix[row][col] = tempCell;

                                    Console.WriteLine($"Swap ({row}, {col}) with ({rowSwap}, {colSwap})");
                                }
                            }
                        }
                    }
                    counter++;
                }
            }
        }

        private static int[][] ShufflingMatrix(int[][] matrix, string commands)
        {
            var tokens = commands.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var rowColNumber = int.Parse(tokens[0]);
            var direction = tokens[1];
            var moves = int.Parse(tokens[2]);

            switch (direction)
            {
                case "up":
                    for (int i = 0; i < moves; i++)
                    {
                        var topElement = matrix[0][rowColNumber];

                        for (int row = 0; row < matrix.Length - 1; row++)
                        {
                            matrix[row][rowColNumber] = matrix[row + 1][rowColNumber];
                        }

                        matrix[matrix.Length - 1][rowColNumber] = topElement;
                    }
                    break;
                case "down":
                    for (int i = 0; i < moves; i++)
                    {
                        var bottomElement = matrix[matrix.Length - 1][rowColNumber];

                        for (int row = matrix.Length - 1; row > 0; row--)
                        {
                            matrix[row][rowColNumber] = matrix[row - 1][rowColNumber];
                        }

                        matrix[0][rowColNumber] = bottomElement;
                    }
                    break;
                case "left":
                    for (int i = 0; i < moves; i++)
                    {
                        var leftMostElement = matrix[rowColNumber][0];

                        for (int col = 0; col < matrix[rowColNumber].Length - 1; col++)
                        {
                            matrix[rowColNumber][col] = matrix[rowColNumber][col + 1];
                        }

                        matrix[rowColNumber][matrix[rowColNumber].Length - 1] = leftMostElement;
                    }
                    break;
                case "right":
                    for (int i = 0; i < moves; i++)
                    {
                        var rightMostElement = matrix[rowColNumber][matrix[rowColNumber].Length - 1];

                        for (int col = matrix[rowColNumber].Length - 1; col > 0; col--)
                        {
                            matrix[rowColNumber][col] = matrix[rowColNumber][col - 1];
                        }

                        matrix[rowColNumber][0] = rightMostElement;
                    }
                    break;
            }

            return matrix;
        }
    }
}
