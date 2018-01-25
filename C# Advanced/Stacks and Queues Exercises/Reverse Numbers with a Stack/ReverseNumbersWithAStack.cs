using System;
using System.Collections.Generic;
using System.Linq;

namespace Reverse_Numbers_with_a_Stack
{
    public class ReverseNumbersWithAStack
    {
        public static void Main()
        {
            var inputNumbers = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse);

            var numbers = new Stack<int>(inputNumbers);

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
