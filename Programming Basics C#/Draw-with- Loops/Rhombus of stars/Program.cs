using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rhombus_of_stars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете n=");
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int l = 0; l < n - i; l++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
                     
            for (int k = 1; k < n; k++)
            {
                for (int a = 0; a < k; a++)
                {
                    Console.Write(" ");
                }
                for (int m = 0; m < n - k; m++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
