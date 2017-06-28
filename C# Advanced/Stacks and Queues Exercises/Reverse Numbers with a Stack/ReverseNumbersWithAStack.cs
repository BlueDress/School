using System;
using System.Collections.Generic;
using System.Linq;

namespace Reverse_Numbers_with_a_Stack
{
    public class ReverseNumbersWithAStack
    {
        public static void Main()
        {
            var inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var numbers = new Stack<int>(inputNumbers);

            var reversedInput = numbers.ToArray();

            Console.WriteLine(string.Join(" ", reversedInput));
        }
    }
}
