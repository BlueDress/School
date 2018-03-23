using System;

namespace Sneaking
{
    public class Startup
    {
        public static void Main()
        {
            var numberOfRows = int.Parse(Console.ReadLine());

            var room = new string[numberOfRows][];
            var nikoladzesRow = 0;
            var nikoladzesCol = 0;
            var samsRow = 0;
            var samsCol = 0;

            for (int i = 0; i < numberOfRows; i++)
            {
                var inputRow = Console.ReadLine();

                room[i] = new string[inputRow.Length];

                for (int j = 0; j < inputRow.Length; j++)
                {
                    room[i][j] = inputRow[j].ToString();

                    if (inputRow[j].ToString().Equals("N"))
                    {
                        nikoladzesRow = i;
                        nikoladzesCol = j;
                    }

                    if (inputRow[j].ToString().Equals("S"))
                    {
                        samsRow = i;
                        samsCol = j;
                    }
                }
            }

            var directions = Console.ReadLine();
            var gameEnded = false;

            for (int d = 0; d < directions.Length; d++)
            {
                if (gameEnded)
                {
                    break;
                }

                for (int i = 0; i < numberOfRows; i++)
                {
                    if (gameEnded)
                    {
                        break;
                    }

                    if (i == nikoladzesRow)
                    {
                        continue;
                    }

                    for (int j = 0; j < room[i].Length; j++)
                    {
                        if (room[i][j].Equals("b"))
                        {
                            if (j == room[i].Length - 1)
                            {
                                room[i][j] = "d";
                            }
                            else
                            {
                                room[i][j] = ".";
                                room[i][j + 1] = "b";
                            }

                            break;
                        }

                        if (room[i][j].Equals("d"))
                        {
                            if (j == 0)
                            {
                                room[i][j] = "b";
                            }
                            else
                            {
                                room[i][j] = ".";
                                room[i][j - 1] = "d";
                            }

                            break;
                        }
                    }
                }

                for (int i = 0; i < numberOfRows; i++)
                {
                    if (gameEnded)
                    {
                        break;
                    }

                    for (int j = 0; j < room[i].Length; j++)
                    {
                        if (room[i][j].Equals("b"))
                        {
                            if (i == samsRow && j < samsCol)
                            {
                                room[samsRow][samsCol] = "X";
                                Console.WriteLine($"Sam died at {samsRow}, {samsCol}");
                                gameEnded = true;
                                break;
                            }
                        }

                        if (room[i][j].Equals("d"))
                        {
                            if (i == samsRow && j > samsCol)
                            {
                                room[samsRow][samsCol] = "X";
                                Console.WriteLine($"Sam died at {samsRow}, {samsCol}");
                                gameEnded = true;
                                break;
                            }
                        }
                    }
                }

                if (gameEnded)
                {
                    break;
                }

                switch (directions[d])
                {
                    case 'U':
                        room[samsRow][samsCol] = ".";
                        samsRow--;
                        room[samsRow][samsCol] = "S";

                        if (samsRow == nikoladzesRow)
                        {
                            Console.WriteLine("Nikoladze killed!");
                            room[nikoladzesRow][nikoladzesCol] = "X";
                            gameEnded = true;
                        }

                        break;
                    case 'D':
                        room[samsRow][samsCol] = ".";
                        samsRow++;
                        room[samsRow][samsCol] = "S";

                        if (samsRow == nikoladzesRow)
                        {
                            Console.WriteLine("Nikoladze killed!");
                            room[nikoladzesRow][nikoladzesCol] = "X";
                            gameEnded = true;
                        }

                        break;
                    case 'L':
                        room[samsRow][samsCol] = ".";
                        samsCol--;
                        room[samsRow][samsCol] = "S";

                        break;
                    case 'R':
                        room[samsRow][samsCol] = ".";
                        samsCol++;
                        room[samsRow][samsCol] = "S";

                        break;
                }
            }

            foreach (var row in room)
            {
                Console.WriteLine(string.Join("", row));
            }
        }
    }
}
