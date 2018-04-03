using System;
using System.Linq;

namespace SortWords
{
    public class Startup
    {
        public static void Main()
        {
            var words = Console.ReadLine().Split().ToList();

            Console.WriteLine(string.Join(" ", words.OrderBy(w => w)));
        }
    }
}
