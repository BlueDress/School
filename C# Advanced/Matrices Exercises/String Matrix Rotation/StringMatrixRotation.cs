using System;
using System.Collections.Generic;

namespace String_Matrix_Rotation
{
    public class StringMatrixRotation
    {
        public static void Main()
        {
            var rotateCommand = Console.ReadLine();
            var degrees = int.Parse(rotateCommand.Substring(7, rotateCommand.Length - 8));

            var matrixLines = new List<string>();

            while (true)
            {
                var inputLine = Console.ReadLine();

                if (inputLine.Equals("END"))
                {
                    break;
                }
                else
                {
                    matrixLines.Add(inputLine);
                }
            }

            var maxLenght = 0;

            for (int i = 0; i < matrixLines.Count; i++)
            {
                var currentLenght = matrixLines[i].Length;

                if (maxLenght < currentLenght)
                {
                    maxLenght = currentLenght;
                }
            }

            var rows = matrixLines.Count;

            var matrix = new char[rows][];

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = matrixLines[row].PadRight(maxLenght).ToCharArray();
            }

            var numberOfRotations = (degrees / 90) % 4;
            var rotatedMatrixRow = 0;
            var rotatedMatrixCol = 0;

            switch (numberOfRotations)
            {
                case 0:
                    foreach (var line in matrix)
                    {
                        Console.WriteLine(string.Join("", line));
                    }
                    break;
                case 1:
                    var rotatedMatrixRight = new char[maxLenght][];

                    for (int row = 0; row < rotatedMatrixRight.Length; row++)
                    {
                        rotatedMatrixRight[row] = new char[matrix.Length];
                    }

                    for (int row = matrix.Length - 1; row >= 0; row--)
                    {
                        rotatedMatrixRow = 0;

                        for (int col = 0; col < matrix[row].Length; col++)
                        {
                            rotatedMatrixRight[rotatedMatrixRow][rotatedMatrixCol] = matrix[row][col];
                            rotatedMatrixRow++;
                        }

                        rotatedMatrixCol++;
                    }

                    foreach (var row in rotatedMatrixRight)
                    {
                        Console.WriteLine(string.Join("", row));
                    }

                    break;
                case 2:
                    var rotatedMatrixMirror = new char[rows][];

                    for (int row = 0; row < rotatedMatrixMirror.Length; row++)
                    {
                        rotatedMatrixMirror[row] = new char[maxLenght];
                    }

                    for (int row = matrix.Length - 1; row >= 0; row--)
                    {
                        rotatedMatrixCol = 0;

                        for (int col = matrix[row].Length - 1; col >= 0; col--)
                        {
                            rotatedMatrixMirror[rotatedMatrixRow][rotatedMatrixCol] = matrix[row][col];
                            rotatedMatrixCol++;
                        }

                        rotatedMatrixRow++;
                    }

                    foreach (var row in rotatedMatrixMirror)
                    {
                        Console.WriteLine(string.Join("", row));
                    }

                    break;
                case 3:
                    var rotatedMatrixLeft = new char[maxLenght][];

                    for (int row = 0; row < rotatedMatrixLeft.Length; row++)
                    {
                        rotatedMatrixLeft[row] = new char[matrix.Length];
                    }

                    for (int row = 0; row < matrix.Length; row++)
                    {
                        rotatedMatrixRow = 0;

                        for (int col = matrix[row].Length - 1; col >= 0; col--)
                        {
                            rotatedMatrixLeft[rotatedMatrixRow][rotatedMatrixCol] = matrix[row][col];
                            rotatedMatrixRow++;
                        }

                        rotatedMatrixCol++;
                    }

                    foreach (var row in rotatedMatrixLeft)
                    {
                        Console.WriteLine(string.Join("", row));
                    }

                    break;
            }
        }
    }
}
