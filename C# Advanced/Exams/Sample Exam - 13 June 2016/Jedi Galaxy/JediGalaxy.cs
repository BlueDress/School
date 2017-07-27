using System;
using System.Linq;

namespace Jedi_Galaxy
{
    public class JediGalaxy
    {
        public static void Main()
        {
            var dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var rows = dimensions[0];
            var cols = dimensions[1];

            var matrix = new int[rows][];
            var matrixFiller = 0;

            for (int row = 0; row < rows; row++)
            {
                matrix[row] = new int[cols];
                for (int col = 0; col < cols; col++)
                {
                    matrix[row][col] = matrixFiller;
                    matrixFiller++;
                }
            }

            var sumOfAllStars = 0;

            while (true)
            {
                var input = Console.ReadLine();

                if (input.Equals("Let the Force be with you"))
                {
                    break;
                }
                else
                {
                    var ivosCoords = input.Split().Select(int.Parse).ToArray();
                    var ivosRow = ivosCoords[0];
                    var ivosCol = ivosCoords[1];

                    var evilsCoords = Console.ReadLine().Split().Select(int.Parse).ToArray();
                    var evilsRow = evilsCoords[0];
                    var evilsCol = evilsCoords[1];

                    if (ivosRow + ivosCol < 0 || rows + cols - 2 < ivosRow + ivosCol)
                    {
                        sumOfAllStars += 0;
                    }
                    else
                    {
                        var ivosStartRow = 0;
                        var ivosStartCol = 0;

                        if (ivosRow + ivosCol < rows)
                        {
                            ivosStartRow = ivosRow + ivosCol;
                            ivosStartCol = 0;
                        }
                        else
                        {
                            ivosStartRow = rows - 1;
                            ivosStartCol = ivosRow + ivosCol - ivosStartRow;
                        }

                        if (evilsCol - evilsRow < 1 - rows || cols - 1 < evilsCol - evilsRow)
                        {
                            for (int row = ivosStartRow, col = ivosStartCol; row >= 0 && col < cols; row--, col++)
                            {
                                sumOfAllStars += matrix[row][col];
                            }
                        }
                        else
                        {
                            var evilsStartRow = 0;
                            var evilsStartCol = 0;

                            if (evilsCol - evilsRow > 0 - rows && evilsCol - evilsRow <= cols - rows)
                            {
                                evilsStartRow = rows - 1;
                                evilsStartCol = evilsStartRow + (evilsCol - evilsRow);
                            }
                            else
                            {
                                evilsStartCol = cols - 1;
                                evilsStartRow = evilsStartCol - (evilsCol - evilsRow);
                            }

                            for (int row = evilsStartRow, col = evilsStartCol; row >= 0 && col >= 0; row--, col--)
                            {
                                matrix[row][col] = 0;
                            }

                            for (int row = ivosStartRow, col = ivosStartCol; row >= 0 && col < cols; row--, col++)
                            {
                                sumOfAllStars += matrix[row][col];
                            }
                        }

                        matrixFiller = 0;

                        for (int row = 0; row < rows; row++)
                        {
                            matrix[row] = new int[cols];
                            for (int col = 0; col < cols; col++)
                            {
                                matrix[row][col] = matrixFiller;
                                matrixFiller++;
                            }
                        }
                    }
                }
            }

            Console.WriteLine(sumOfAllStars);
        }
    }
}
