using System;
using System.Collections.Generic;
using System.Linq;
namespace Sum__Min__Max__Average
{
    public class SumMinMaxAverage
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var inputNumbers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                inputNumbers.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine($"Sum = {inputNumbers.Sum()}");
            Console.WriteLine($"Min = {inputNumbers.Min()}");
            Console.WriteLine($"Max = {inputNumbers.Max()}");
            Console.WriteLine($"Average = {inputNumbers.Average()}");
        }
    }
}
