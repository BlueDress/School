using System;

namespace Pascal_Triangle
{
    public class PascalTriangle
    {
        public static void Main()
        {
            var endRow = int.Parse(Console.ReadLine());

            var pascalTriangle = new int[endRow][];

            for (int row = 0; row < pascalTriangle.Length; row++)
            {
                pascalTriangle[row] = new int[row + 1];
                pascalTriangle[row][0] = 1;
                pascalTriangle[row][row] = 1;

                for (int col = 1; col < pascalTriangle[row].Length - 1; col++)
                {
                    pascalTriangle[row][col] = pascalTriangle[row - 1][col - 1] + pascalTriangle[row - 1][col];
                }
            }

            foreach (var row in pascalTriangle)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
