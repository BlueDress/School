using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Calculator
{
    class Program
    {
        public static void GetArea(string figureType)
        {
            if (figureType == "triangle")
            {
                var side = double.Parse(Console.ReadLine());
                var height = double.Parse(Console.ReadLine());
                var area = side * height / 2;
                Console.WriteLine($"{area:f2}");
            }
            else if (figureType == "rectangle")
            {
                var side = double.Parse(Console.ReadLine());
                var height = double.Parse(Console.ReadLine());
                var area = side * height;
                Console.WriteLine($"{area:f2}");
            }
            else if (figureType == "square")
            {
                var side = double.Parse(Console.ReadLine());
                var area = side * side;
                Console.WriteLine($"{area:f2}");
            }
            else if (figureType == "circle")
            {
                var side = double.Parse(Console.ReadLine());
                var area = side * side * Math.PI;
                Console.WriteLine($"{area:f2}");
            }
        }
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();
            GetArea(figureType);
        }
    }
}
