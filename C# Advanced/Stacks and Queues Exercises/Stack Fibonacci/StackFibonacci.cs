using System;
using System.Collections.Generic;

namespace Stack_Fibonacci
{
    public class StackFibonacci
    {
        public static void Main()
        {
            var nthNumber = long.Parse(Console.ReadLine());
            var numbers = new Stack<long>();

            numbers.Push(1);
            numbers.Push(1);

            for (int i = 2; i < nthNumber; i++)
            {
                var secondNumber = numbers.Pop();
                var firstNumber = numbers.Pop();
                var thirdNumber = firstNumber + secondNumber;
                numbers.Push(secondNumber);
                numbers.Push(thirdNumber);
            }

            Console.WriteLine(numbers.Peek());
        }
    }
}
