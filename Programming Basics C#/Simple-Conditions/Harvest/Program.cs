using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете площа на лозето ");
            var s = int.Parse(Console.ReadLine());

            Console.Write("Въведете добив на грозде от кв.м. ");
            var l = double.Parse(Console.ReadLine());

            Console.Write("Въведете нужните литри ");
            var v = int.Parse(Console.ReadLine());

            Console.Write("Въведете броя на работниците ");
            var p = int.Parse(Console.ReadLine());

            var total = (((s * 0.4) * l) * 0.4);

            if (total < v)
            {
                var a = Math.Floor(v - total);
                Console.WriteLine($"It will be a tough winter ! More {a} liters wine needed.");
            }
            else
            {
                var a = Math.Ceiling(total - v);
                var b = Math.Ceiling(a / p);
                Console.WriteLine($"Good harvest this year! Total wine: {total} liters.");
                Console.WriteLine($"{a} liters left -> {b} liters per person.");
            }
        }
    }
}
