using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Factorial_Trailing_Zeroes
{
    class Program
    {
        public static BigInteger Factorial(int n)
        {
            BigInteger sum = 1;

            for (int i = 1; i <= n; i++)
            {
                sum *= i;
            }
            return sum;
        }
        public static int FactorialTrailingZeroes(BigInteger n)
        {
            var counter = 0;
            while (n > 0)
            {
                if (n % 10 == 0)
                {
                    counter++;
                    n /= 10;
                }
                else
                {
                    break;
                }
            }
            return counter;
        }
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var factorial = Factorial(number);
            var trailingZeroes = FactorialTrailingZeroes(factorial);
            Console.WriteLine(trailingZeroes);
        }
    }
}
