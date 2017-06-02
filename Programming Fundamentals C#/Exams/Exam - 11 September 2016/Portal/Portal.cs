using System;

namespace Portal
{
    public class Portal
    {
        public static void Main()
        {
            var mapSize = int.Parse(Console.ReadLine());
            var map = new char[mapSize][];

            for (int row = 0; row < mapSize; row++)
            {
                var charRow = Console.ReadLine().ToCharArray();
                map[row] = new char[charRow.Length];

                for (int col = 0; col < charRow.Length; col++)
                {
                    map[row][col] = charRow[col];
                }
            }

            var currentCellRow = 0;
            var currentCellCol = 0;
            var exitCellRow = 0;
            var exitCellCol = 0;

            for (int row = 0; row < map.Length; row++)
            {
                for (int col = 0; col < map[row].Length; col++)
                {
                    if (map[row][col].Equals('S'))
                    {
                        currentCellRow = row;
                        currentCellCol = col;
                    }

                    if (map[row][col].Equals('E'))
                    {
                        exitCellRow = row;
                        exitCellCol = col;
                    }
                }
            }
            var turns = 0;
            var directions = Console.ReadLine().ToCharArray();

            foreach (var symbol in directions)
            {
                switch (symbol)
                {
                    case 'R':

                        if (currentCellCol == map[currentCellRow].Length - 1)
                        {
                            currentCellCol = 0;
                            turns++;
                        }
                        else
                        {
                            currentCellCol++;
                            turns++;
                        }
                        break;

                    case 'L':

                        if (currentCellCol == 0)
                        {
                            currentCellCol = map[currentCellRow].Length - 1;
                            turns++;
                        }
                        else
                        {
                            currentCellCol--;
                            turns++;
                        }
                        break;

                    case 'D':

                        var moveDownPossible = false;

                        for (int row = currentCellRow + 1; row < map.Length; row++)
                        {
                            if (map[row].Length > currentCellCol)
                            {
                                currentCellRow = row;
                                turns++;
                                moveDownPossible = true;
                                break;
                            }
                        }

                        if (moveDownPossible == false)
                        {
                            for (int row = 0; row < currentCellRow; row++)
                            {
                                if (map[row].Length > currentCellCol)
                                {
                                    currentCellRow = row;
                                    turns++;
                                    moveDownPossible = true;
                                    break;
                                }
                            }
                        }

                        if (moveDownPossible == false)
                        {
                            turns++;
                        }
                        break;

                    case 'U':

                        var moveUpPossible = false;

                        for (int row = currentCellRow - 1; row >= 0; row--)
                        {
                            if (map[row].Length > currentCellCol)
                            {
                                currentCellRow = row;
                                turns++;
                                moveUpPossible = true;
                                break;
                            }
                        }

                        if (moveUpPossible == false)
                        {
                            for (int row = map.Length - 1; row > currentCellRow; row--)
                            {
                                if (map[row].Length > currentCellCol)
                                {
                                    currentCellRow = row;
                                    turns++;
                                    moveUpPossible = true;
                                    break;
                                }
                            }
                        }

                        if (moveUpPossible == false)
                        {
                            turns++;
                        }
                        break;
                }
            }

            if (currentCellRow == exitCellRow && currentCellCol == exitCellCol)
            {
                Console.WriteLine($"Experiment successful. {turns} turns required.");
            }
            else
            {
                Console.WriteLine($"Robot stuck at {currentCellRow} {currentCellCol}. Experiment failed.");
            }
        }
    }
}
