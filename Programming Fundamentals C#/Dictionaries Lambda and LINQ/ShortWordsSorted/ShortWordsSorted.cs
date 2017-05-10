using System;
using System.Collections.Generic;
using System.Linq;

namespace ShortWordsSorted
{
    public class ShortWordsSorted
    {
        public static void Main()
        {
            Console.WriteLine(string.Join(", ", Console.ReadLine()
                .ToLower()
                .Split(new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .Distinct()
                .OrderBy(x => x)
                .Where(x => x.Length < 5)));
        }
    }
}
