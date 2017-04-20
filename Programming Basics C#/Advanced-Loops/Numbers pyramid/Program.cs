using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете число ");
            var n = int.Parse(Console.ReadLine());
            var num = 1;

            for (int i = 1; i <=n; i++)
            {
                for (int j = 1; j <=i; j++)
                {
                    Console.Write($"{num} ");
                    num++;
                    if (num > n) break;
                }
                Console.WriteLine();
                if (num > n) break;
            }
        }
    }
}
