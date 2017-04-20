using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_Odd_Sum_Minel_Maxel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете брой чилса ");
            var n = int.Parse(Console.ReadLine());

            double oddsum = 0;
            double evensum = 0;

            var oddmax = double.MinValue;
            var oddmin = double.MaxValue;
            var evenmax = double.MinValue;
            var evenmin = double.MaxValue;

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Въведи число ");
                var num = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evensum += num;
                    if (num > evenmax) evenmax = num;
                    if (num < evenmin) evenmin = num;
                }
                else
                {
                    oddsum += num;
                    if (num > oddmax) oddmax = num;
                    if (num < oddmin) oddmin = num;
                }
            }
            Console.WriteLine($"OddSum={oddsum}");
            if (oddmin == double.MaxValue) Console.WriteLine($"OddMin=No");
            else Console.WriteLine($"OddMin={oddmin}");
            if (oddmax == double.MinValue) Console.WriteLine($"OddMax=No");
            else Console.WriteLine($"OddMax={oddmax}");

            Console.WriteLine($"EvenSum={evensum}");
            if (evenmin == double.MaxValue) Console.WriteLine($"EvenMin=No");
            else Console.WriteLine($"EvenMin={evenmin}");
            if (evenmax == double.MinValue) Console.WriteLine($"EvenMax=No");
            else Console.WriteLine($"EvenMax={evenmax}");
        }
    }
}
