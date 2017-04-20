using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divide_without_Remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете брой числа ");
            var n = int.Parse(Console.ReadLine());

            var p2 = 0.0;
            var p3 = 0.0;
            var p4 = 0.0;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Въведете число ");
                var p = int.Parse(Console.ReadLine());

                if (p % 2 == 0) p2++;
                if (p % 3 == 0) p3++;
                if (p % 4 == 0) p4++;

            }
            p2 = Math.Round(((p2 * 100) / n), 2);
            p3 = Math.Round(((p3 * 100) / n), 2);
            p4 = Math.Round(((p4 * 100) / n), 2);

            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
        }
    }
}
