using System;
using System.Linq;

namespace Sum_Numbers
{
    public class SumNumbers
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            Console.WriteLine((String.Join(", ", input.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Count())));

            Console.WriteLine((String.Join(", ", input.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Sum())));
        }
    }
}
