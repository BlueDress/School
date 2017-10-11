using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Numbers
{
    class Program
    {
        public static void Fib(int n)
        {
            if (n == 0)
            {
                Console.WriteLine(n + 1);
                return;
            }

            var a = 0;
            var b = 1;
            var sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum = a + b;
                a = b;
                b = sum;
            }
            Console.WriteLine(sum);
        }
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Fib(n);
        }
    }
}
