using System;
using System.Linq;

namespace Max_Sequence_of_Equal_Elements
{
    class MaxSequenceOfEqualElements
    {
        static void Main()
        {
            int[] Input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var maxSequence = 0;
            var element = 0;

            for (int currentElement = 0; currentElement < Input.Length; currentElement++)
            {
                var counter = 1;
                for (int nextElement = currentElement + 1; nextElement < Input.Length; nextElement++)
                {
                    if (Input[currentElement] == Input[nextElement])
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
                    element = Input[currentElement];
                }
            }
            for (int i = 0; i < maxSequence; i++)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }
}
