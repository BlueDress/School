using System;
using System.Linq;

namespace Rotate_and_Sum
{
    class RotateAndSum
    {
        static void Main()
        {
            int[] Input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var k = int.Parse(Console.ReadLine());

            int[] Sum = new int[Input.Length];
            int[] Rotated = new int[Input.Length];
            Rotated[0] = Input[Input.Length - 1];

            for (int i = 0; i < 1; i++)
            {
                for (int j = 1; j < Rotated.Length; j++)
                {
                    Rotated[j] = Input[j - 1];
                    Sum[j] = Rotated[j];
                }
                Sum[0] = Rotated[0];
            }

            for (int i = 1; i < k; i++)
            {
                for (int j = i; j < Rotated.Length; j++)
                {
                    Sum[j] = Sum[j] + Rotated[j - i];
                }
                for (int p = 1; p < i; p++)
                {
                    Sum[p] = Sum[p] + Rotated[Rotated.Length - p];
                }
                Sum[0] = Rotated[Rotated.Length - i] + Sum[0];
            }
            Console.WriteLine(string.Join(" ", Sum));
        }
    }
}
