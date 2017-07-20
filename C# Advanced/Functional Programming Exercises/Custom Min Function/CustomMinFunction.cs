using System;
using System.Linq;

namespace Custom_Min_Function
{
    public class CustomMinFunction
    {
        public static void Main()
        {
            Func<int,int,int> FindMinNumber = (x, y) => Math.Min(x, y);

            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var minNumber = int.MaxValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                minNumber = FindMinNumber(minNumber, numbers[i]);
            }

            Console.WriteLine(minNumber);
        }
    }
}
