using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_a_Rectangular_plane_coords
{
    class Program
    {
        static void Main(string[] args)
        {
         //   Console.WriteLine("Въведете координатите на долния десен ъгъл");
         //   Console.Write("x1 = ");
            var x1 = double.Parse(Console.ReadLine());
         //   Console.Write("y1 = ");
            var y1 = double.Parse(Console.ReadLine());
         //   Console.WriteLine("Въведете координатите на горния ляв ъгъл ");
         //   Console.Write("x2 = ");
            var x2 = double.Parse(Console.ReadLine());
         //   Console.Write("y2 = ");
            var y2 = double.Parse(Console.ReadLine());
            var p = (2 * (Math.Abs(x1 - x2) + Math.Abs(y2 - y1)));
            var s = Math.Abs((x1 - x2) * (y2 - y1));
            Console.WriteLine(s);
            Console.WriteLine(p);
        }
    }
}
