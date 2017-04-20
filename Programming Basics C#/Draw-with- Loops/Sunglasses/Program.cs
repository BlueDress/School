using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете n=");
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}{0}", new string('*', 2 * n), new string(' ', n));
            for (int i = 1; i <= n - 2; i++)
            {
                if (i == (n - 1) / 2 )
                    Console.WriteLine("*{0}*{1}*{0}*", new string('/', 2 * (n - 1)), new string('|', n));                
                else
                    Console.WriteLine("*{0}*{1}*{0}*", new string('/', 2 * (n - 1)), new string(' ', n));
            }
            Console.WriteLine("{0}{1}{0}", new string('*', 2 * n), new string(' ', n));
        }
    }
}
