using System;
using System.Linq;

namespace Equal_Sums
{
    class EqualSums
    {
        static void Main()
        {
            int[] Input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            bool noSuchElement = true;

            for (int index = 0; index < Input.Length; index++)
            {
                var leftSum = 0;
                for (int leftIndex = index; leftIndex > 0; leftIndex--)
                {
                    leftSum = leftSum + Input[leftIndex - 1];
                }

                var rightSum = 0;
                for (int rightIndex = index; rightIndex < Input.Length - 1; rightIndex++)
                {
                    rightSum = rightSum + Input[rightIndex + 1];
                }

                if (leftSum == rightSum)
                {
                    Console.Write(index + " ");
                    noSuchElement = false;
                }
            }
            if (noSuchElement)
            {
                Console.WriteLine("No");
            }
            Console.WriteLine();
        }
    }
}
