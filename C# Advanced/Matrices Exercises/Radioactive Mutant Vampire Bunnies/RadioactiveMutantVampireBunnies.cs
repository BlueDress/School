using System;
using System.Collections.Generic;
using System.Linq;

namespace Radioactive_Mutant_Vampire_Bunnies
{
    public class RadioactiveMutantVampireBunnies
    {
        public static void Main()
        {
            var dimensions = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var rows = dimensions[0];
            var cols = dimensions[1];

            var lair = new char[rows][];

            for (int row = 0; row < rows; row++)
            {
                lair[row] = Console.ReadLine().ToCharArray();
            }
            
            var bunnyCells = new List<BunnyCell>();
            var playerRow = 0;
            var playerCol = 0;

            for (int row = 0; row < lair.Length; row++)
            {
                for (int col = 0; col < lair[row].Length; col++)
                {
                    if (lair[row][col].Equals('P'))
                    {
                        playerRow = row;
                        playerCol = col;
                    }

                    if (lair[row][col].Equals('B'))
                    {
                        var bunnyCell = new BunnyCell
                        {
                            row = row,
                            col = col
                        };
                        bunnyCells.Add(bunnyCell);
                    }
                }
            }

            var commands = Console.ReadLine().ToCharArray();
            var playerWon = false;
            var playerDead = false;

            for (int i = 0; i < commands.Length; i++)
            {
                switch (commands[i])
                {
                    case 'U':
                        if (playerRow == 0)
                        {
                            playerWon = true;
                            lair[playerRow][playerCol] = '.';
                        }
                        else
                        {
                            if (lair[playerRow - 1][playerCol].Equals('B'))
                            {
                                playerDead = true;
                                playerRow = playerRow - 1;
                                lair[playerRow][playerCol] = '.';
                            }
                            else
                            {
                                lair[playerRow][playerCol] = '.';
                                playerRow = playerRow - 1;
                                lair[playerRow][playerCol] = 'P';
                            }
                        }

                        foreach (var bunnyCell in bunnyCells)
                        {
                            if (lair[bunnyCell.row][Math.Min(bunnyCell.col + 1, lair[bunnyCell.row].Length - 1)].Equals('P'))
                            {
                                playerDead = true;
                                lair[bunnyCell.row][Math.Min(bunnyCell.col + 1, lair[bunnyCell.row].Length - 1)] = 'B';
                            }
                            else
                            {
                                lair[bunnyCell.row][Math.Min(bunnyCell.col + 1, lair[bunnyCell.row].Length - 1)] = 'B';
                            }

                            if (lair[bunnyCell.row][Math.Max(bunnyCell.col - 1, 0)].Equals('P'))
                            {
                                playerDead = true;
                                lair[bunnyCell.row][Math.Max(bunnyCell.col - 1, 0)] = 'B';
                            }
                            else
                            {
                                lair[bunnyCell.row][Math.Max(bunnyCell.col - 1, 0)] = 'B';
                            }

                            if (lair[Math.Min(bunnyCell.row + 1, lair.Length - 1)][bunnyCell.col].Equals('P'))
                            {
                                playerDead = true;
                                lair[Math.Min(bunnyCell.row + 1, lair.Length - 1)][bunnyCell.col] = 'B';
                            }
                            else
                            {
                                lair[Math.Min(bunnyCell.row + 1, lair.Length - 1)][bunnyCell.col] = 'B';
                            }

                            if (lair[Math.Max(bunnyCell.row - 1, 0)][bunnyCell.col].Equals('P'))
                            {
                                playerDead = true;
                                lair[Math.Max(bunnyCell.row - 1, 0)][bunnyCell.col] = 'B';
                            }
                            else
                            {
                                lair[Math.Max(bunnyCell.row - 1, 0)][bunnyCell.col] = 'B';
                            }
                        }
                        break;
                    case 'D':
                        if (playerRow == lair.Length - 1)
                        {
                            playerWon = true;
                            lair[playerRow][playerCol] = '.';
                        }
                        else
                        {
                            if (lair[playerRow - 1][playerCol].Equals('B'))
                            {
                                playerDead = true;
                                playerRow = playerRow + 1;
                                lair[playerRow][playerCol] = '.';
                            }
                            else
                            {
                                lair[playerRow][playerCol] = '.';
                                playerRow = playerRow + 1;
                                lair[playerRow][playerCol] = 'P';
                            }
                        }

                        foreach (var bunnyCell in bunnyCells)
                        {
                            if (lair[bunnyCell.row][Math.Min(bunnyCell.col + 1, lair[bunnyCell.row].Length - 1)].Equals('P'))
                            {
                                playerDead = true;
                                lair[bunnyCell.row][Math.Min(bunnyCell.col + 1, lair[bunnyCell.row].Length - 1)] = 'B';
                            }
                            else
                            {
                                lair[bunnyCell.row][Math.Min(bunnyCell.col + 1, lair[bunnyCell.row].Length - 1)] = 'B';
                            }

                            if (lair[bunnyCell.row][Math.Max(bunnyCell.col - 1, 0)].Equals('P'))
                            {
                                playerDead = true;
                                lair[bunnyCell.row][Math.Max(bunnyCell.col - 1, 0)] = 'B';
                            }
                            else
                            {
                                lair[bunnyCell.row][Math.Max(bunnyCell.col - 1, 0)] = 'B';
                            }

                            if (lair[Math.Min(bunnyCell.row + 1, lair.Length - 1)][bunnyCell.col].Equals('P'))
                            {
                                playerDead = true;
                                lair[Math.Min(bunnyCell.row + 1, lair.Length - 1)][bunnyCell.col] = 'B';
                            }
                            else
                            {
                                lair[Math.Min(bunnyCell.row + 1, lair.Length - 1)][bunnyCell.col] = 'B';
                            }

                            if (lair[Math.Max(bunnyCell.row - 1, 0)][bunnyCell.col].Equals('P'))
                            {
                                playerDead = true;
                                lair[Math.Max(bunnyCell.row - 1, 0)][bunnyCell.col] = 'B';
                            }
                            else
                            {
                                lair[Math.Max(bunnyCell.row - 1, 0)][bunnyCell.col] = 'B';
                            }
                        }
                        break;
                    case 'L':
                        if (playerCol == 0)
                        {
                            playerWon = true;
                            lair[playerRow][playerCol] = '.';
                        }
                        else
                        {
                            if (lair[playerRow][playerCol - 1].Equals('B'))
                            {
                                playerDead = true;
                                playerCol = playerCol - 1;
                                lair[playerRow][playerCol] = '.';
                            }
                            else
                            {
                                lair[playerRow][playerCol] = '.';
                                playerCol = playerCol - 1;
                                lair[playerRow][playerCol] = 'P';
                            }
                        }

                        foreach (var bunnyCell in bunnyCells)
                        {
                            if (lair[bunnyCell.row][Math.Min(bunnyCell.col + 1, lair[bunnyCell.row].Length - 1)].Equals('P'))
                            {
                                playerDead = true;
                                lair[bunnyCell.row][Math.Min(bunnyCell.col + 1, lair[bunnyCell.row].Length - 1)] = 'B';
                            }
                            else
                            {
                                lair[bunnyCell.row][Math.Min(bunnyCell.col + 1, lair[bunnyCell.row].Length - 1)] = 'B';
                            }

                            if (lair[bunnyCell.row][Math.Max(bunnyCell.col - 1, 0)].Equals('P'))
                            {
                                playerDead = true;
                                lair[bunnyCell.row][Math.Max(bunnyCell.col - 1, 0)] = 'B';
                            }
                            else
                            {
                                lair[bunnyCell.row][Math.Max(bunnyCell.col - 1, 0)] = 'B';
                            }

                            if (lair[Math.Min(bunnyCell.row + 1, lair.Length - 1)][bunnyCell.col].Equals('P'))
                            {
                                playerDead = true;
                                lair[Math.Min(bunnyCell.row + 1, lair.Length - 1)][bunnyCell.col] = 'B';
                            }
                            else
                            {
                                lair[Math.Min(bunnyCell.row + 1, lair.Length - 1)][bunnyCell.col] = 'B';
                            }

                            if (lair[Math.Max(bunnyCell.row - 1, 0)][bunnyCell.col].Equals('P'))
                            {
                                playerDead = true;
                                lair[Math.Max(bunnyCell.row - 1, 0)][bunnyCell.col] = 'B';
                            }
                            else
                            {
                                lair[Math.Max(bunnyCell.row - 1, 0)][bunnyCell.col] = 'B';
                            }
                        }
                        break;
                    case 'R':
                        if (playerCol == lair[playerRow].Length - 1)
                        {
                            playerWon = true;
                            lair[playerRow][playerCol] = '.';
                        }
                        else
                        {
                            if (lair[playerRow][playerCol - 1].Equals('B'))
                            {
                                playerDead = true;
                                playerCol = playerCol + 1;
                                lair[playerRow][playerCol] = '.';
                            }
                            else
                            {
                                lair[playerRow][playerCol] = '.';
                                playerCol = playerCol + 1;
                                lair[playerRow][playerCol] = 'P';
                            }
                        }

                        foreach (var bunnyCell in bunnyCells)
                        {
                            if (lair[bunnyCell.row][Math.Min(bunnyCell.col + 1, lair[bunnyCell.row].Length - 1)].Equals('P'))
                            {
                                playerDead = true;
                                lair[bunnyCell.row][Math.Min(bunnyCell.col + 1, lair[bunnyCell.row].Length - 1)] = 'B';
                            }
                            else
                            {
                                lair[bunnyCell.row][Math.Min(bunnyCell.col + 1, lair[bunnyCell.row].Length - 1)] = 'B';
                            }

                            if (lair[bunnyCell.row][Math.Max(bunnyCell.col - 1, 0)].Equals('P'))
                            {
                                playerDead = true;
                                lair[bunnyCell.row][Math.Max(bunnyCell.col - 1, 0)] = 'B';
                            }
                            else
                            {
                                lair[bunnyCell.row][Math.Max(bunnyCell.col - 1, 0)] = 'B';
                            }

                            if (lair[Math.Min(bunnyCell.row + 1, lair.Length - 1)][bunnyCell.col].Equals('P'))
                            {
                                playerDead = true;
                                lair[Math.Min(bunnyCell.row + 1, lair.Length - 1)][bunnyCell.col] = 'B';
                            }
                            else
                            {
                                lair[Math.Min(bunnyCell.row + 1, lair.Length - 1)][bunnyCell.col] = 'B';
                            }

                            if (lair[Math.Max(bunnyCell.row - 1, 0)][bunnyCell.col].Equals('P'))
                            {
                                playerDead = true;
                                lair[Math.Max(bunnyCell.row - 1, 0)][bunnyCell.col] = 'B';
                            }
                            else
                            {
                                lair[Math.Max(bunnyCell.row - 1, 0)][bunnyCell.col] = 'B';
                            }
                        }
                        break;
                }

                for (int row = 0; row < lair.Length; row++)
                {
                    for (int col = 0; col < lair[row].Length; col++)
                    {
                        if (lair[row][col].Equals('B'))
                        {
                            var bunnyCell = new BunnyCell
                            {
                                row = row,
                                col = col
                            };
                            bunnyCells.Add(bunnyCell);
                        }
                    }
                }

                if (playerWon || playerDead)
                {
                    break;
                }
            }

            foreach (var row in lair)
            {
                Console.WriteLine(string.Join("", row));
            }

            if (playerWon)
            {
                Console.WriteLine($"won: {playerRow} {playerCol}");
            }

            if (playerDead)
            {
                Console.WriteLine($"dead: {playerRow} {playerCol}");
            }
        }
    }
}
