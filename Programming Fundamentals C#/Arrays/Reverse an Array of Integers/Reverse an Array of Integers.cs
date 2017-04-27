using System;

namespace Reverse_an_Array_of_Integers
{
    class ReverseAnArrayOfIntegers
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var numbers = new int[n];
            var revertedNumbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                revertedNumbers[numbers.Length - 1 - i] = numbers[i];
            }
           /* for (int i = 0; i < n; i++)
            {
                Console.Write(revertedNumbers[i] + " ");
            }*/
            Console.WriteLine(string.Join(" ", revertedNumbers));
        }
    }
}
