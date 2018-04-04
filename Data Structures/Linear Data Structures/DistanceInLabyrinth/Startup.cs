using System;

namespace DistanceInLabyrinth
{
    public class Startup
    {
        public static void Main()
        {
            var mazeDimensions = int.Parse(Console.ReadLine());

            var maze = new MazeCell[mazeDimensions][];
            var startCell = new MazeCell();

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

            FindDistance(startCell, maze);

            for (int i = 0; i < mazeDimensions; i++)
            {
                for (int j = 0; j < mazeDimensions; j++)
                {
                    Console.Write(maze[i][j].Value);
                }

                Console.WriteLine();
            }
        }

        private static void FindDistance(MazeCell startCell, MazeCell[][] maze)
        {
            var value = startCell.Value.Equals("*") ? 0 : int.Parse(startCell.Value);
            
            if (startCell.Left != null)
            {
                startCell.Left = maze[startCell.Row][startCell.Column - 1];

                if (!startCell.Left.IsChecked)
                {
                    startCell.Left.Value = (value + 1).ToString();
                    startCell.Left.IsChecked = true;

                    FindDistance(startCell.Left, maze);
                }
            }

            if (startCell.Right != null)
            {
                startCell.Right = maze[startCell.Row][startCell.Column + 1];

                if (!startCell.Right.IsChecked)
                {
                    startCell.Right.Value = (value + 1).ToString();
                    startCell.Right.IsChecked = true;

                    FindDistance(startCell.Right, maze);
                }
            }

            if (startCell.Top != null)
            {
                startCell.Top = maze[startCell.Row - 1][startCell.Column];

                if (!startCell.Top.IsChecked)
                {
                    startCell.Top.Value = (value + 1).ToString();
                    startCell.Top.IsChecked = true;

                    FindDistance(startCell.Top, maze);
                }
            }

            if (startCell.Bottom != null)
            {
                startCell.Bottom = maze[startCell.Row + 1][startCell.Column];

                if (!startCell.Bottom.IsChecked)
                {
                    startCell.Bottom.Value = (value + 1).ToString();
                    startCell.Bottom.IsChecked = true;

                    FindDistance(startCell.Bottom, maze);
                }
            }
        }
    }
}
