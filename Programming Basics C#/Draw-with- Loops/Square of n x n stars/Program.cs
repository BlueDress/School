using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_of_n_x_n_stars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете n=");
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("*");
            }
        }
    }
}
