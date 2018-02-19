using System;

namespace Knight_Game
{
    public class Startup
    {
        public static void Main()
        {
            var dimensions = int.Parse(Console.ReadLine());

            var board = new string[dimensions][];

            for (int i = 0; i < dimensions; i++)
            {
                var input = Console.ReadLine();
                board[i] = new string[dimensions];

                for (int j = 0; j < dimensions; j++)
                {
                    if (input[j].Equals('K'))
                    {
                        board[i][j] = input[j].ToString();
                    }
                    else
                    {
                        board[i][j] = "0";
                    }
                }
            }

            var minKnightsRemoved = 0;

            while (true)
            {
                var maxKnightConections = int.MinValue;

                for (int i = 0; i < dimensions; i++)
                {
                    for (int j = 0; j < dimensions; j++)
                    {
                        var currentCellKnightConnections = 0;

                        if (!board[i][j].Equals("0"))
                        {
                            if (i > 0 && j > 1 && !board[i - 1][j - 2].Equals("0"))
                            {
                                currentCellKnightConnections++;
                            }

                            if (i > 0 && j < dimensions - 2 && !board[i - 1][j + 2].Equals("0"))
                            {
                                currentCellKnightConnections++;
                            }

                            if (i > 1 && j > 0 && !board[i - 2][j - 1].Equals("0"))
                            {
                                currentCellKnightConnections++;
                            }

                            if (i > 1 && j < dimensions - 1 && !board[i - 2][j + 1].Equals("0"))
                            {
                                currentCellKnightConnections++;
                            }

                            if (i < dimensions - 1 && j > 1 && !board[i + 1][j - 2].Equals("0"))
                            {
                                currentCellKnightConnections++;
                            }

                            if (i < dimensions - 1 && j < dimensions - 2 && !board[i + 1][j + 2].Equals("0"))
                            {
                                currentCellKnightConnections++;
                            }

                            if (i < dimensions - 2 && j > 0 && !board[i + 2][j - 1].Equals("0"))
                            {
                                currentCellKnightConnections++;
                            }

                            if (i < dimensions - 2 && j < dimensions - 1 && !board[i + 2][j + 1].Equals("0"))
                            {
                                currentCellKnightConnections++;
                            }
                        }

                        if (currentCellKnightConnections > maxKnightConections)
                        {
                            maxKnightConections = currentCellKnightConnections;
                        }

                        board[i][j] = currentCellKnightConnections.ToString();
                    }
                }

                if (maxKnightConections == 0)
                {
                    break;
                }

                var knightRemoved = false;

                for (int i = 0; i < dimensions; i++)
                {
                    for (int j = 0; j < dimensions; j++)
                    {
                        if (board[i][j].Equals(maxKnightConections.ToString()))
                        {
                            board[i][j] = "0";
                            minKnightsRemoved++;
                            knightRemoved = true;

                            break;
                        }
                    }

                    if (knightRemoved)
                    {
                        break;
                    }
                }
            }

            Console.WriteLine(minKnightsRemoved);
        }
    }
}
