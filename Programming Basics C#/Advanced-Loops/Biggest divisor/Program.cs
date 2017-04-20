using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biggest_divisor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете число ");
            var a = int.Parse(Console.ReadLine());
            Console.Write("Въведете число ");
            var b = int.Parse(Console.ReadLine());

            var n = Math.Min(a, b);

            while (n > 0)
            {
                if (a % n == 0 && b % n == 0)
                {
                    Console.WriteLine(n);
                    break;
                }
                else n--;
            }
        }
    }
}
