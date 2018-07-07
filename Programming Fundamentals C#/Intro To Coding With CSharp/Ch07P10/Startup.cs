using System;
using System.Linq;

namespace Ch07P10
{
    public class Startup
    {
        public static void Main()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int maxSequence = 0;
            int element = input[0];

            for (int currentElement = 0; currentElement < input.Length; currentElement++)
            {
                int counter = 1;

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
