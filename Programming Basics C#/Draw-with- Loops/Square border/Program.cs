using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_border
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете n=");
            var n = int.Parse(Console.ReadLine());

                Console.Write("+ ");
                for (int j = 0; j < n - 2; j++)
                {
                    Console.Write("- ");
                }
                Console.WriteLine("+");
                for (int m = 0; m < n - 2; m++)
                {

                    Console.Write("| ");
                    for (int k = 0; k < n - 2; k++)
                    {
                        Console.Write("- ");
                    }
                    Console.WriteLine("|");
                }
                Console.Write("+ ");
                for (int p = 0; p < n - 2; p++)
                {
                    Console.Write("- ");
                }
                Console.WriteLine("+");
        }
    }
}
