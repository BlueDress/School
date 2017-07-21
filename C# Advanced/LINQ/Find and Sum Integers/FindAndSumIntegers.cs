using System;
using System.Linq;

namespace Find_and_Sum_Integers
{
    public class FindAndSumIntegers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(x =>
            {
                var value = 0d;
                var success = double.TryParse(x, out value);
                return value;
            }).Where(x => x != 0).ToList();

            if (numbers.Count > 0)
            {
                Console.WriteLine(numbers.Sum());
            }
            else
            {
                Console.WriteLine("No match");
            }
        }
    }
}


