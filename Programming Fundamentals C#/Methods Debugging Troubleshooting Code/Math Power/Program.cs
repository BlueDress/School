using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Power
{
    class Program
    {        
        public static long PowerOfNumber(int number, int power)
        {
            var result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= number;
            }
            return result;
        }
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var power = int.Parse(Console.ReadLine());

            var result = PowerOfNumber(number, power);
            Console.WriteLine(result);
        }
    }
}
