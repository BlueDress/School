using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biggest_divisor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете число ");
            var a = int.Parse(Console.ReadLine());
            Console.Write("Въведете число ");
            var b = int.Parse(Console.ReadLine());

            var min = Math.Min(a, b);
            var max = Math.Max(a, b);

            do
            {
                var reminder = max % min;

                if (reminder == 0)
                {
                    Console.WriteLine(min);
                    break;
                }
                else
                {
                    max = min;
                    min = reminder;
                }
            } while (true);
        }
    }
}
