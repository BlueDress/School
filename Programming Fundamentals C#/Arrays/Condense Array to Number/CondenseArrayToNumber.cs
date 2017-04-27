using System;
using System.Linq;

namespace Condense_Array_to_Number
{
    class CondenseArrayToNumber
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            while (input.Length > 1)
            {
                int[] result = new int[input.Length - 1];
                for (int i = 0; i < input.Length - 1; i++)
                {
                    result[i] = input[i] + input[i + 1];
                }
                input = result;
            }
            Console.WriteLine(string.Join("", input));
        }
    }
}
