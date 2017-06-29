using System;
using System.Linq;

namespace Sum_Matrix_Elements
{
    public class SumMatrixElements
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var rows = input[0];
            var cols = input[1];

            var matrix = new int[rows][];
            var sum = 0;

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                sum += matrix[i].Sum();
            }

            Console.WriteLine($"{rows}\n{cols}\n{sum}");
        }
    }
}
