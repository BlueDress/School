using System;
using System.Collections.Generic;

namespace DistanceInLabyrinth
{
    public class Startup
    {
        public static void Main()
        {
            FillMatrix(out int mazeDimensions, out MazeCell[][] maze, out MazeCell startCell);
            FindDistance(startCell, maze);
            PrintResult(mazeDimensions, maze);
        }

        private static void FillMatrix(out int mazeDimensions, out MazeCell[][] maze, out MazeCell startCell)
        {
            mazeDimensions = int.Parse(Console.ReadLine());
            maze = new MazeCell[mazeDimensions][];
            startCell = new MazeCell();

            for (int i = 0; i < mazeDimensions; i++)
            {
                var row = Console.ReadLine();

                maze[i] = new MazeCell[mazeDimensions];

                for (int j = 0; j < mazeDimensions; j++)
                {
                    var cell = new MazeCell
                    {
                        Row = i,
                        Column = j,

                        Top = i == 0 ? null : new MazeCell(),
                        Bottom = i == mazeDimensions - 1 ? null : new MazeCell(),
                        Left = j == 0 ? null : new MazeCell(),
                        Right = j == mazeDimensions - 1 ? null : new MazeCell(),

                        Value = row[j].ToString()
                    };

                    cell.IsChecked = cell.Value.Equals("x") ? true : false;

                    maze[i][j] = cell;

                    if (cell.Value.Equals("*"))
                    {
                        startCell = maze[i][j];
                        startCell.IsChecked = true;
                    }
                }
            }
        }

        private static void FindDistance(MazeCell startCell, MazeCell[][] maze)
        {
            var queue = new Queue<MazeCell>();
            queue.Enqueue(startCell);

            while (true)
            {
                if (queue.Count <= 0)
                {
                    break;
                }

                var nextCell = queue.Dequeue();
                var value = nextCell.Value.Equals("*") ? 0 : int.Parse(nextCell.Value);

                if (nextCell.Left != null)
                {
                    nextCell.Left = maze[nextCell.Row][nextCell.Column - 1];

                    if (!nextCell.Left.IsChecked)
                    {
                        queue.Enqueue(nextCell.Left);

                        nextCell.Left.Value = (value + 1).ToString();
                        nextCell.Left.IsChecked = true;
                    }
                }

                if (nextCell.Right != null)
                {
                    nextCell.Right = maze[nextCell.Row][nextCell.Column + 1];

                    if (!nextCell.Right.IsChecked)
                    {
                        queue.Enqueue(nextCell.Right);

                        nextCell.Right.Value = (value + 1).ToString();
                        nextCell.Right.IsChecked = true;
                    }
                }

                if (nextCell.Top != null)
                {
                    nextCell.Top = maze[nextCell.Row - 1][nextCell.Column];

                    if (!nextCell.Top.IsChecked)
                    {
                        queue.Enqueue(nextCell.Top);

                        nextCell.Top.Value = (value + 1).ToString();
                        nextCell.Top.IsChecked = true;
                    }
                }

                if (nextCell.Bottom != null)
                {
                    nextCell.Bottom = maze[nextCell.Row + 1][nextCell.Column];

                    if (!nextCell.Bottom.IsChecked)
                    {
                        queue.Enqueue(nextCell.Bottom);

                        nextCell.Bottom.Value = (value + 1).ToString();
                        nextCell.Bottom.IsChecked = true;
                    }
                }
            }
        }

        private static void PrintResult(int mazeDimensions, MazeCell[][] maze)
        {
            for (int i = 0; i < mazeDimensions; i++)
            {
                for (int j = 0; j < mazeDimensions; j++)
                {
                    Console.Write(maze[i][j].Value == "0" ? "u" : maze[i][j].Value);
                }

                Console.WriteLine();
            }
        }
    }
}
