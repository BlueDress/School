using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_and_Pipes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Веведете обем на басейна ");
            var v = int.Parse(Console.ReadLine());

            Console.Write("Веведете дебит на първата тръба ");
            var p1 = int.Parse(Console.ReadLine());

            Console.Write("Веведете дебит на втората тръба ");
            var p2 = int.Parse(Console.ReadLine());

            Console.Write("Веведете колко часа работят тръбите ");
            var h = double.Parse(Console.ReadLine());

            var d1 = h * p1;
            var d2 = h * p2;

            if (d1 + d2 > v)
            {
                var overflow = (d1 + d2) - v;
                Console.WriteLine($"За {h} часа басейнът е прелял с {overflow} литра");
            }
            else
            {
                var a = d1 + d2;
                var b = Math.Round((a * 100) / v, 0);
                var c = Math.Round((d1 * 100) / a, 0);
                var d = Math.Round((d2 * 100) / a, 0);
                Console.WriteLine($"За {h} часа басейнът ще е пален на {b}%, първа тръба: {c}%, втора тръба: {d}%");
            }
        }
    }
}
