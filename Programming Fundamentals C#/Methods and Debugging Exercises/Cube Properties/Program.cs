using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cube_Properties
{
    class Program
    {
        public static void CubeProperties(int side, string property)
        {
            var face = side * Math.Sqrt(2);
            var space = side * Math.Sqrt(3);
            var volume = side * side * side;
            var area = side * side;
            if (property == "face") Console.WriteLine(Math.Round(face, 2));
            else if (property == "space") Console.WriteLine(Math.Round(space, 2));
            else if (property == "volume") Console.WriteLine("{0:f2}", volume);
            else if (property == "area") Console.WriteLine($"{area:f2}");
        }
        static void Main(string[] args)
        {
            var side = int.Parse(Console.ReadLine());
            string property = Console.ReadLine();
            CubeProperties(side, property);
        }
    }
}
