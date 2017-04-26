using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw_a_Filled_Square
{
    class Program
    {
        public static void HeaderRow(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }
        public static void PrintBody(int n)
        {
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("-");
                for (int j = 0; j < n - 1; j++)
                {
                    Console.Write("\\/");
                }
                Console.Write("-");
                Console.WriteLine();
            }
        }
        public static void PrintSquare(int n)
        {
            HeaderRow(n);
            PrintBody(n);
            HeaderRow(n);
        }
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            PrintSquare(num);
        }
    }
}
