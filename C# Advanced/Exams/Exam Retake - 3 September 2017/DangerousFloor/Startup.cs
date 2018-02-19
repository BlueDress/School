using System;

namespace DangerousFloor
{
    public class Startup
    {
        public static void Main()
        {
            var board = new string[8][];

            for (int i = 0; i < 8; i++)
            {
                var input = Console.ReadLine().Split(',');

                board[i] = new string[8];

                for (int j = 0; j < 8; j++)
                {
                    board[i][j] = input[j];
                }
            }

            while (true)
            {
                var input = Console.ReadLine();

                if (input.Equals("END"))
                {
                    break;
                }

                var pieceType = input[0];

                var currentRow = int.Parse(input[1].ToString());
                var currentCol = int.Parse(input[2].ToString());

                var finalRow = int.Parse(input[4].ToString());
                var finalCol = int.Parse(input[5].ToString());

                if (!board[currentRow][currentCol].Equals(pieceType.ToString()))
                {
                    Console.WriteLine("There is no such a piece!");
                    continue;
                }

                switch (pieceType)
                {
                    case 'K':
                        if (!((finalRow + 1 == currentRow && (finalCol == currentCol - 1 || finalCol == currentCol || finalCol == currentCol + 1) || (finalRow - 1 == currentRow && (finalCol == currentCol - 1 || finalCol == currentCol || finalCol == currentCol + 1))) || (finalRow == currentRow && (finalCol - 1 == currentCol || finalCol + 1 == currentCol))))
                        {
                            Console.WriteLine("Invalid move!");
                            continue;
                        }
                        break;
                    case 'R':
                        if (!((finalRow == currentRow) || (finalCol == currentCol)))
                        {
                            Console.WriteLine("Invalid move!");
                            continue;
                        }
                        break;
                    case 'B':
                        if (!(Math.Abs(finalRow - currentRow) == Math.Abs(finalCol - currentCol)))
                        {
                            Console.WriteLine("Invalid move!");
                            continue;
                        }
                        break;
                    case 'Q':
                        if (!(((finalRow == currentRow) || (finalCol == currentCol)) || (Math.Abs(finalRow - currentRow) == Math.Abs(finalCol - currentCol))))
                        {
                            Console.WriteLine("Invalid move!");
                            continue;
                        }
                        break;
                    case 'P':
                        if (!((finalRow + 1 == currentRow) && (finalCol == currentCol)))
                        { 
                            Console.WriteLine("Invalid move!");
                            continue;
                        }
                        break;
                }

                if (finalRow > 7 || finalCol > 7)
                {
                    Console.WriteLine("Move go out of board!");
                    continue;
                }

                board[currentRow][currentCol] = "x";
                board[finalRow][finalCol] = pieceType.ToString();
            }
        }
    }
}
