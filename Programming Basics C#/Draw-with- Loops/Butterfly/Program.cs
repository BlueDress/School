using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butterfly
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете число ");
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n - 2; i++)
            {
                if (i % 2 == 0) Console.WriteLine("{0}\\ /{0}", new string('*', n - 2));
                else Console.WriteLine("{0}\\ /{0}", new string('-', n - 2));
            }
            Console.WriteLine("{0}@{0}", new string(' ', n - 1));
            for (int i = 0; i < n - 2; i++)
            {
                if (i % 2 == 0) Console.WriteLine("{0}/ \\{0}", new string('*', n - 2));
                else Console.WriteLine("{0}/ \\{0}", new string('-', n - 2));
            }
        }
    }
}
