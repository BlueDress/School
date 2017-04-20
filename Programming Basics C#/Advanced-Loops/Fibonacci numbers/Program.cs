using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете число ");
            var n = int.Parse(Console.ReadLine());

            var a = 0;
            var b = 1;
            var sum = 0;
            var check = 0;

            do
            {
                sum = a + b;
                a = b;
                b = sum;
                check++;
            } while (check < n);
                Console.WriteLine(sum);
        }
    }
}
