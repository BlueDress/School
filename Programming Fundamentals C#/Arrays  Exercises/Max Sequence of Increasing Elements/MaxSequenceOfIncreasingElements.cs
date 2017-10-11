using System;
using System.Linq;
namespace Max_Sequence_of_Increasing_Elements
{
    class MaxSequenceOfIncreasingElements
    {
        static void Main()
        {
            int[] Input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var maxSequence = 0;
            var element = 0;

            for (int currentElement = 0; currentElement < Input.Length; currentElement++)
            {
                var counter = 1;
                for (int nextElement = currentElement; nextElement < Input.Length - 1; nextElement++)
                {
                    if (Input[nextElement] < Input[nextElement + 1])
                    {
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (counter > maxSequence)
                {
                    maxSequence = counter;
                    element = currentElement;
                }
            }
            for (int i = element; i < element + maxSequence; i++)
            {
                Console.Write(Input[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
