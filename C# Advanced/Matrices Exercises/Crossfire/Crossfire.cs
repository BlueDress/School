using System;
using System.Collections.Generic;
using System.Linq;

namespace Crossfire
{
    public class Program
    {
        public static void Main()
        {
            var dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var rows = dimensions[0];
            var cols = dimensions[1];

            var matrix = new List<List<int>>();
            var counter = 1;

            for (int row = 0; row < rows; row++)
            {
                var sublist = new List<int>();

                for (int col = 0; col < cols; col++)
                {
                    sublist.Add(counter);
                    counter++;
                }
                matrix.Add(sublist);
            }

            while (true)
            {
                var input = Console.ReadLine();

                if (input.Equals("Nuke it from orbit"))
                {
                    break;
                }
                else
                {
                    for (int i = matrix.Count - 1; i >= 0; i--)
                    {
                        if (matrix[i].Count == 0)
                        {
                            matrix.RemoveAt(i);
                        }
                    }

                    var commands = input.Split().Select(int.Parse).ToArray();

                    var row = commands[0];
                    var col = commands[1];
                    var radius = commands[2];

                    if (row < matrix.Count)
                    {
                        var temp = matrix[row].Count;

                        for (int i = Math.Max(0, col - radius); i <= Math.Min(col + radius, temp - 1); i++)
                        {
                            matrix[row].RemoveAt(Math.Max(0, col - radius));
                        }
                    }

                    for (int i = Math.Max(0, row - radius); i <= Math.Min(row + radius, matrix.Count - 1); i++)
                    {
                        if (matrix[i].Count > col)
                        {
                            matrix[i].RemoveAt(col);
                        }
                    }
                }
            }

            foreach (var row in matrix)
            {
                if (row.Count > 0)
                {
                    Console.WriteLine(string.Join(" ", row));
                }
            }
        }
    }
}
