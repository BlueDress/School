using System;
using System.Linq;

namespace Generic_Swap_Method_Integers
{
    public class Startup
    {
        public static void Main()
        {
            var numberOfInts = int.Parse(Console.ReadLine());
            var intBox = new Box<int>();

            for (int i = 0; i < numberOfInts; i++)
            {
                var newInt = int.Parse(Console.ReadLine());
                intBox.Add(newInt);
            }

            var swapIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var indexOfFirstElement = swapIndexes[0];
            var indexOfSecondElement = swapIndexes[1];

            intBox.Swap(indexOfFirstElement, indexOfSecondElement);
            Console.WriteLine(intBox);
        }
    }
}
