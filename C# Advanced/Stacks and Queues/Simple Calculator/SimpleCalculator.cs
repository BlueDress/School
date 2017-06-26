using System;
using System.Collections.Generic;
using System.Linq;

namespace Simple_Calculator
{
    public class SimpleCalculator
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();
            var stack = new Stack<string>(input.Reverse());

            while (stack.Count > 1)
            {
                var firstNumber = int.Parse(stack.Pop());
                var operand = stack.Pop();
                var secondNumber = int.Parse(stack.Pop());

                if (operand.Equals("+"))
                {
                    stack.Push((firstNumber + secondNumber).ToString());
                }
                else
                {
                    stack.Push((firstNumber - secondNumber).ToString());
                }
            }

            Console.WriteLine(stack.Peek());
        }
    }
}
