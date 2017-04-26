using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Factorial
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
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            BigInteger result = Factorial(n);
            Console.WriteLine(result);
        }
    }
}
