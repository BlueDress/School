using System;
using System.Linq;

namespace Ch22P06
{
    public class Startup
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.WriteLine(string.Join(", ", numbers.Where(n => n % 7 == 0 && n % 3 == 0)));

            var result = from number in numbers where number % 7 == 0 && number % 3 == 0 select number;

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
