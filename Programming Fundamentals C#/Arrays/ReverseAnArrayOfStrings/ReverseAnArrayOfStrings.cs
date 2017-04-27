using System;

namespace ReverseAnArrayOfStrings
{
    class ReverseAnArrayOfStrings
    {
        static void Main()
        {
            string[] array = Console.ReadLine().Split();
            string[] reversedArray = new string[array.Length];

            for (int i = 0; i < reversedArray.Length; i++)
            {
                reversedArray[i] = array[array.Length - 1 - i];
            }
            Console.WriteLine(string.Join(" ", reversedArray));
        }
    }
}
