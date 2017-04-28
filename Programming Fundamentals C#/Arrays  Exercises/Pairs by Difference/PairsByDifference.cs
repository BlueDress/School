using System;
using System.Linq;

namespace Pairs_by_Difference
{
    class PairsByDifference
    {
        static void Main()
        {
            int[] Input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var difference = int.Parse(Console.ReadLine());
            var output = 0;

            for (int i = 0; i < Input.Length; i++)
            {
                for (int j = i + 1; j < Input.Length; j++)
                {
                    if (Math.Abs(Input[i] - Input[j]) == difference)
                    {
                        output++;
                    }
                }
            }
            Console.WriteLine(output);
        }
    }
}
