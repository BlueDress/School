using System;

namespace Lego_Blocks
{
    public class LegoBlocks
    {
        public static void Main()
        {
            var numberOfRows = int.Parse(Console.ReadLine());

            var firstJagged = new string[numberOfRows][];
            var secondJagged = new string[numberOfRows][];

            for (int row = 0; row < numberOfRows; row++)
            {
                firstJagged[row] = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }

            for (int row = 0; row < numberOfRows; row++)
            {
                secondJagged[row] = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }

            var lenght = firstJagged[0].Length + secondJagged[0].Length;
            var isPerfectFit = true;

            for (int row = 1; row < numberOfRows; row++)
            {
                var currentLenght = firstJagged[row].Length + secondJagged[row].Length;

                if (lenght != currentLenght)
                {
                    isPerfectFit = false;
                }
            }

            if (!isPerfectFit)
            {
                var totalCells = 0;

                for (int row = 0; row < numberOfRows; row++)
                {
                    totalCells += firstJagged[row].Length + secondJagged[row].Length;
                }

                Console.WriteLine($"The total number of cells is: {totalCells}");
            }
            else
            {
                var matrix = new string[numberOfRows][];

                for (int row = 0; row < numberOfRows; row++)
                {
                    matrix[row] = new string[lenght];

                    for (int i = 0; i < firstJagged[row].Length; i++)
                    {
                        matrix[row][i] = firstJagged[row][i];
                    }

                    for (int i = firstJagged[row].Length, j = secondJagged[row].Length - 1; i < matrix[row].Length; i++, j--)
                    {
                        matrix[row][i] = secondJagged[row][j];
                    }
                }

                foreach (var row in matrix)
                {
                    Console.WriteLine($"[{string.Join(", ", row)}]");
                }
            }
        }
    }
}
