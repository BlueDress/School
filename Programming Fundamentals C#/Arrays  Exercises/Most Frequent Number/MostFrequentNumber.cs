using System;
using System.Linq;

namespace Most_Frequent_Number
{
    class MostFrequentNumber
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var maxSequence = 0;
            var element = input[0];

            for (int currentElement = 0; currentElement < input.Length; currentElement++)
            {
                var counter = 1;
                for (int nextElement = currentElement; nextElement < input.Length - 1; nextElement++)
                {
                    if (input[currentElement] == input[nextElement + 1])
                    {
                        counter++;
                    }
                }
                if (counter > maxSequence)
                {
                    maxSequence = counter;
                    element = input[currentElement];
                }
            }
            Console.WriteLine(element);
        }
    }
}
