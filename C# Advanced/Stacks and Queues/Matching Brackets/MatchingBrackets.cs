using System;
using System.Collections.Generic;

namespace Matching_Brackets
{
    public class MatchingBrackets
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Equals('('))
                {
                    stack.Push(i);
                }

                if (input[i].Equals(')'))
                {
                    var startIndex = stack.Pop();
                    Console.WriteLine(input.Substring(startIndex, i - startIndex + 1));
                }
            }
        }
    }
}
