using System;
using System.Linq;

namespace Sort_Even_Numbers
{
    public class SortEvenNumbers
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            Console.WriteLine(String.Join(", ", input.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Where(x => x % 2 == 0).ToList()));

            Console.WriteLine(String.Join(", ", input.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Where(x => x % 2 == 0).OrderBy(x => x).ToList()));
        }
    }
}
