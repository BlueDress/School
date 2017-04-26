using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printing_Triangle
{
    class Program
    {
        public static void PrintTriangle(int n)
        {
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();
            }
            for (int row = n - 1; row >= 1; row--)
            {
                var a = 0;
                for (int col = row; col >= 1; col--)
                {
                    a++;
                    Console.Write(a + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            PrintTriangle(num);
        }
    }
}
