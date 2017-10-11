using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine(new string('#', 4 * n + 1));

            var j = 1;

            for (int i = 1; i <= n; i++)
            {
                if (i == n / 2 + 1)
                {
                    Console.WriteLine("{0}{1}{2}(@){2}{1}{0}", new string('.', i), new string('#', ((4 * n) + 1 - (2 * i) - j) / 2), new string(' ', (j - 3) / 2));
                    j += 2;
                }
                else
                {
                    Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', i), new string('#', ((4 * n) + 1 - (2 * i) - j) / 2), new string(' ', j));
                    j += 2;
                }
            }
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', n + i), new string('#', 2 * n - 2 * i + 1));
            }
        }
    }
}
