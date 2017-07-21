using System;
using System.Linq;

namespace BoundedNumbers
{
    public class BoundedNumbers
    {
        public static void Main()
        {
            var bounds = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.WriteLine(string.Join(" ", Console.ReadLine().Split().Select(int.Parse).Where(x => bounds.Min() <= x && x <= bounds.Max())));
        }
    }
}
