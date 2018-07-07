using System;
using System.Collections.Generic;
using System.Linq;

namespace Ch10P10
{
    public class Startup
    {
        private static List<char> path = new List<char>();

        private static char[,] labyrinth =
            {
                {'-', '-', '-', '*', '-', '-', '-'},
                {'*', '*', '-', '*', '-', '*', '-'},
                {'-', '-', '-', '-', '-', '-', '-'},
                {'-', '*', '*', '*', '*', '*', '-'},
                {'-', '-', '-', '-', '-', '-', 'e'},
            };

        public static void Main()
        {
            FindPaths(0, 0, 'S');
        }

        private static void FindPaths(int row, int col, char direction)
        {
            if (!IsVallidCell(row, col))
            {
                return;
            }

            path.Add(direction);

            if (labyrinth[row, col].Equals('e'))
            {
                PrintPath();
            }
            else if (labyrinth[row, col] != 'v')
            {
                labyrinth[row, col] = 'v';

                FindPaths(row, col + 1, 'R');
                FindPaths(row + 1, col, 'D');
                FindPaths(row, col - 1, 'L');
                FindPaths(row - 1, col, 'U');

                labyrinth[row, col] = '-';
            }

            path.RemoveAt(path.Count - 1);
        }

        private static bool IsVallidCell(int row, int col)
        {
            return 0 <= row && row < labyrinth.GetLength(0) && 0 <= col && col < labyrinth.GetLength(1) && labyrinth[row, col] != '*';
        }

        private static void PrintPath()
        {

            Console.WriteLine(string.Join("", path.Skip(1)));
        }
    }
}
