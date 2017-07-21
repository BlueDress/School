using System;
using System.Linq;

namespace Upper_Strings
{
    public class UpperStrings
    {
        public static void Main()
        {
            Console.WriteLine(string.Join(" ", Console.ReadLine().ToUpper().Split()));
        }
    }
}
