using System;
using System.Linq;

namespace Count_Uppercase_Words
{
    public class CountUppercaseWords
    {
        public static void Main()
        {
            Console.ReadLine().Split().Where(x => StartsWithUppercase(x)).ToList().ForEach(x => Console.WriteLine(x));
        }

        private static bool StartsWithUppercase(string x)
        {
            if (char.IsUpper(x[0]))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
