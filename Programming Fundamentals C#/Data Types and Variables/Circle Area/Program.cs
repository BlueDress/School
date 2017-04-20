using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете радиус ");
            double r = double.Parse(Console.ReadLine());

            double s = Math.PI * r * r;
            Console.WriteLine($"{s:f12}");
        }
    }
}
