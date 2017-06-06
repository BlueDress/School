using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете n=");
            var n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                for (int i = 2; i <= n; i += 2)
                {
                    Console.WriteLine("{0}{1}{0}", new string('-', (n - i) / 2), new string('*', i));
                }
                for (int i = 2; i <= n; i += 2)
                {
                    Console.WriteLine("|{0}|", new string('*', n - 2));
                }
            }
            else
            {
                for (int i = 1; i <= n; i += 2)
                {
                    Console.WriteLine("{0}{1}{0}", new string('-', (n - i) / 2), new string('*', i));
                }
                for (int i = 1; i < n; i += 2)
                {
                    Console.WriteLine("|{0}|", new string('*', n - 2));
                }
            }
        }
    }
}
