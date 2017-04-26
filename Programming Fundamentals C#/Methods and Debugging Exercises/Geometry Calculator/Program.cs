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
                var side = int.Parse(Console.ReadLine());
                var height = int.Parse(Console.ReadLine());
                var area = side * height / 2;
                Console.WriteLine(area);
            }
            else if (figureType == "rectangle")
            {
                var side = int.Parse(Console.ReadLine());
                var height = int.Parse(Console.ReadLine());
                var area = side * height;
                Console.WriteLine(area);
            }
            else if (figureType == "square")
            {
                var side = int.Parse(Console.ReadLine());
                var area = side * side;
                Console.WriteLine(area);
            }
            else if (figureType == "circle")
            {
                var side = int.Parse(Console.ReadLine());
                var area = side * side * Math.PI;
                Console.WriteLine(area);
            }
        }
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();
            GetArea(figureType);
        }
    }
}
