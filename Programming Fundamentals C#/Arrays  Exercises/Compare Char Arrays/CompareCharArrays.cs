using System;
using System.Linq;

namespace Compare_Char_Arrays
{
    class CompareCharArrays
    {
        static void Main()
        {
            char[] FirstArray = Console.ReadLine().Split().Select(char.Parse).ToArray();
            char[] SecondArray = Console.ReadLine().Split().Select(char.Parse).ToArray();

            bool arraysAreEqual = true;

            for (int i = 0; i < Math.Min(FirstArray.Length, SecondArray.Length); i++)
            {
                if (FirstArray[i] < SecondArray[i])
                {
                    Console.WriteLine(string.Join("", FirstArray));
                    Console.WriteLine(string.Join("", SecondArray));
                    arraysAreEqual = false;
                    break;
                }
                else if (FirstArray[i] > SecondArray[i])
                {
                    Console.WriteLine(string.Join("", SecondArray));
                    Console.WriteLine(string.Join("", FirstArray));
                    arraysAreEqual = false;
                    break;
                }
            }
            if (arraysAreEqual == true)
            {
                if (SecondArray.Length >= FirstArray.Length)
                {
                    Console.WriteLine(string.Join("", FirstArray));
                    Console.WriteLine(string.Join("", SecondArray));
                }
                else
                {
                    Console.WriteLine(string.Join("", SecondArray));
                    Console.WriteLine(string.Join("", FirstArray));
                }
            }
        }
    }
}
