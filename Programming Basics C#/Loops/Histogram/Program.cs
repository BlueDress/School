using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете брой числа ");
            var n = int.Parse(Console.ReadLine());

            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Въведете число ");
                var p = int.Parse(Console.ReadLine());

                if (p < 200) p1 += 1;
                else if (p >= 200 && p < 400) p2 += 1;
                else if (p >= 400 && p < 600) p3 += 1;
                else if (p >= 600 && p < 800) p4 += 1;
                else p5 += 1;
            }
            p1 = Math.Round(((p1 * 100) / n), 2);
            p2 = Math.Round(((p2 * 100) / n), 2);
            p3 = Math.Round(((p3 * 100) / n), 2);
            p4 = Math.Round(((p4 * 100) / n), 2);
            p5 = Math.Round(((p5 * 100) / n), 2);

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");
        }
    }
}
