using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longer_Line
{
    class Program
    {
        public static void CloserToCentre(double x1, double y1, double x2, double y2)
        {
            if (Math.Sqrt(x1 * x1 + y1 * y1) > Math.Sqrt(x2 * x2 + y2 * y2))
            {
                Console.Write($"({x2}, {y2})");
            }
            else
            {
                Console.Write($"({x1}, {y1})");
            }
        }
        public static void FarFromCentre(double x1, double y1, double x2, double y2)
        {
            if (Math.Sqrt(x1 * x1 + y1 * y1) > Math.Sqrt(x2 * x2 + y2 * y2))
            {
                Console.Write($"({x1}, {y1})");
            }
            else
            {
                Console.Write($"({x2}, {y2})");
            }
        }
        public static void LongerLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            if (Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2)) >= Math.Sqrt((x3 - x4) * (x3 - x4) + (y3 - y4) * (y3 - y4)))
            {
                CloserToCentre(x1, y1, x2, y2);
                FarFromCentre(x1, y1, x2, y2);
                Console.WriteLine();
            }
            else
            {
                CloserToCentre(x3, y3, x4, y4);
                FarFromCentre(x3, y3, x4, y4);
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var x3 = double.Parse(Console.ReadLine());
            var y3 = double.Parse(Console.ReadLine());
            var x4 = double.Parse(Console.ReadLine());
            var y4 = double.Parse(Console.ReadLine());

            LongerLine(x1, y1, x2, y2, x3, y3, x4, y4);
        }
    }
}
