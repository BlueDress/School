using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_table
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете число ");
            var n = int.Parse(Console.ReadLine());
            var num = 0;

            for (int i = 1; i <= n; i++)
            {
                num = i;
                for (int j = 1; j <= n; j++)
                {
                    Console.Write($"{num} ");
                    num++;
                    if (num > n) break;
                }
                if (num > n)
                {
                    for (int p = n - 1; p >= n - i + 1; p--)
                    {
                        Console.Write($"{p} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
