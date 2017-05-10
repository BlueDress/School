using System;
using System.Collections.Generic;
using System.Linq;

namespace Largest_3_Numbers
{
    public class Largest3Numbers
    {
        public static void Main()
        {
            Console.WriteLine(string.Join(" ", Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList()
                .OrderByDescending(x => x)
                .Take(3)));
        }
    }
}
