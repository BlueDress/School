using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Center_Point
{
    class Program
    {
        public static void CloserToCentre(double x1, double y1, double x2, double y2)
        {
            if (Math.Sqrt((x1 * x1) + (y1 * y1)) > Math.Sqrt((x2 * x2) + (y2 * y2)))
            {
                Console.WriteLine($"({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x1}, {y1})");
            }
        }
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());

            CloserToCentre(x1, y1, x2, y2);
        }
    }
}
