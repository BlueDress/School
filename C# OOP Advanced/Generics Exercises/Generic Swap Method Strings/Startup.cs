using System;
using System.Linq;

namespace Generic_Swap_Method_Strings
{
    public class Startup
    {
        public static void Main()
        {
            var numberOfStrings = int.Parse(Console.ReadLine());
            var stringBox = new Box<string>();

            for (int i = 0; i < numberOfStrings; i++)
            {
                var newString = Console.ReadLine();
                stringBox.Add(newString);
            }

            var swapIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var indexOfFirstElement = swapIndexes[0];
            var indexOfSecondElement = swapIndexes[1];

            stringBox.Swap(indexOfFirstElement, indexOfSecondElement);
            Console.WriteLine(stringBox);
        }
    }
}
