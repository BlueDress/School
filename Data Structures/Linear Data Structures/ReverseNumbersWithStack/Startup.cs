using System;
using System.Collections.Generic;

namespace ReverseNumbersWithStack
{
    public class Startup
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split();
            var numbersStack = new Stack<string>();

            foreach (var number in numbers)
            {
                numbersStack.Push(number);
            }

            foreach (var number in numbersStack)
            {
                Console.Write($"{number} ");
            }

            Console.WriteLine();
        }
    }
}
