using System;
using System.Linq;

namespace Average_of_Doubles
{
    public class AverageOfDoubles
    {
        public static void Main()
        {
            Console.WriteLine($"{Console.ReadLine().Split().Select(double.Parse).Average():f2}");
        }
    }
}
