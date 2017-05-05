using System;
using System.Collections.Generic;
using System.Linq;

namespace Sort_Numbers
{
    public class SortNumbers
    {
        public static void Main()
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            input.Sort();
            Console.WriteLine(string.Join(" <= ", input));
        }
    }
}
