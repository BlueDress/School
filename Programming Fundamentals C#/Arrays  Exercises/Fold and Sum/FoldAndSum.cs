using System;
using System.Linq;

namespace Fold_and_Sum
{
    class FoldAndSum
    {
        static void Main()
        {
            int[] Input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] MiddleOfInput = new int[Input.Length / 2];

            for (int i = 0; i < MiddleOfInput.Length; i++)
            {
                MiddleOfInput[i] = Input[Input.Length / 4 + i];
            }

            int[] FrontFold = new int[Input.Length / 4];

            for (int i = 0; i < FrontFold.Length; i++)
            {
                FrontFold[i] = Input[Input.Length / 4 - 1 - i];
            }

            int[] BackFold = new int[Input.Length / 4];

            for (int i = 0; i < BackFold.Length; i++)
            {
                BackFold[i] = Input[Input.Length - 1 - i];
            }

            int[] Output = new int[Input.Length / 2];

            for (int i = 0; i < Output.Length / 2; i++)
            {
                Output[i] = FrontFold[i] + MiddleOfInput[i];
            }

            for (int i = 0; i < Output.Length / 2; i++)
            {
                Output[Output.Length / 2 + i] = MiddleOfInput[MiddleOfInput.Length / 2 + i] + BackFold[i];
            }
            Console.WriteLine(string.Join(" ", Output));
        }
    }
}
