using System;
using System.Linq;

namespace Take_Two
{
    public class TakeTwo
    {
        public static void Main()
        {
            Console.WriteLine(string.Join(" ",Console.ReadLine().Split().Select(int.Parse).Distinct().Where(x => 10 <= x && x <= 20).Take(2)));
        }
    }
}
