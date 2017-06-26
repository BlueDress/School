using System;
using System.Collections.Generic;

namespace Decimal_to_Binary_Converter
{
    public class DecimalToBinaryConverter
    {
        public static void Main()
        {
            var decimalNumber = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();
            

            while (decimalNumber > 0)
            {
                stack.Push(decimalNumber % 2);
                decimalNumber = decimalNumber / 2;
            }

            var binaryNumber = string.Join("", stack.ToArray());
            Console.WriteLine(binaryNumber);
        }
    }
}
