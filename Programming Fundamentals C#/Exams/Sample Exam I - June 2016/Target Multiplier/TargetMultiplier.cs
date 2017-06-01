using System;
using System.Linq;

namespace Target_Multiplier
{
    public class TargetMultiplier
    {
        public static void Main()
        {
            var rowsAndColumns = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var rows = rowsAndColumns[0];
            var columns = rowsAndColumns[1];

            var matrixValues = new string[rows];

            for (int i = 0; i < rows; i++)
            {
                matrixValues[i] = Console.ReadLine();
            }

            var positionOfCell = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var targetRow = positionOfCell[0];
            var targetColumn = positionOfCell[1];

            var rowOfTargetCell = matrixValues[targetRow].Split().Select(int.Parse).ToArray();
            var valueOfTargetCell = rowOfTargetCell[targetColumn];

            var previousRowOfTargetCell = matrixValues[targetRow - 1].Split().Select(int.Parse).ToArray();
            var nextRowOfTargetCell = matrixValues[targetRow + 1].Split().Select(int.Parse).ToArray();

            var sumOfNeighboringCells = previousRowOfTargetCell[targetColumn - 1] + previousRowOfTargetCell[targetColumn] + previousRowOfTargetCell[targetColumn + 1] +
                                        rowOfTargetCell[targetColumn - 1] + rowOfTargetCell[targetColumn + 1] +
                                        nextRowOfTargetCell[targetColumn - 1] + nextRowOfTargetCell[targetColumn] + nextRowOfTargetCell[targetColumn + 1];

            rowOfTargetCell[targetColumn] = valueOfTargetCell * sumOfNeighboringCells;
            rowOfTargetCell[targetColumn - 1] *= valueOfTargetCell;
            rowOfTargetCell[targetColumn + 1] *= valueOfTargetCell;
            previousRowOfTargetCell[targetColumn - 1] *= valueOfTargetCell;
            previousRowOfTargetCell[targetColumn] *= valueOfTargetCell;
            previousRowOfTargetCell[targetColumn + 1] *= valueOfTargetCell;
            nextRowOfTargetCell[targetColumn - 1] *= valueOfTargetCell;
            nextRowOfTargetCell[targetColumn] *= valueOfTargetCell;
            nextRowOfTargetCell[targetColumn + 1] *= valueOfTargetCell;

            matrixValues[targetRow] = string.Join(" ", rowOfTargetCell);
            matrixValues[targetRow - 1] = string.Join(" ", previousRowOfTargetCell);
            matrixValues[targetRow + 1] = string.Join(" ", nextRowOfTargetCell);

            foreach (var row in matrixValues)
            {
                Console.WriteLine(row);
            }
        }
    }
}
