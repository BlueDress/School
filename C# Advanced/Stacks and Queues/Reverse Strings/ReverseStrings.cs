using System;
using System.Collections.Generic;

namespace Reverse_Strings
{
    public class ReverseStrings
    {
        public static void Main()
        {
            var inputString = Console.ReadLine();
            var stack = new Stack<char>();

            for (int i = 0; i < inputString.Length; i++)
            {
                stack.Push(inputString[i]);
            }

            var reversedInput = string.Join("", stack.ToArray());
            Console.WriteLine(reversedInput);
        }
    }
}
