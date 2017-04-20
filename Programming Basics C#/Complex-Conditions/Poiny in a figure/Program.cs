using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poiny_in_a_figure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете размер на страната на блокчетата ");
            var h = int.Parse(Console.ReadLine());

            Console.Write("Въведете x ");
            var x = int.Parse(Console.ReadLine());

            Console.Write("Въведете y ");
            var y = int.Parse(Console.ReadLine());

            if (((x > 0 && x < 3 * h) && (y > 0 && y < h)) || ((x > h && x < 2 * h) && (y >= h && y <= 4 * h)))
            {
                Console.WriteLine("inside");
            }
            else if ((x >= 0 && x <= 3 * h) && (y == 0) || (((x >= 0 && x <= h) || (x >= 2 * h && x <= 3 * h)) && (y == h)) || ((x >= 2 * h && x <= 3 * h) && (y == 4 * h)) || ((y >= 0 && y <= h) && (x == 0 || x == 3 * h)) || ((y >= h && y <= 4 * h) && (x == h || x == 2 * h)))
            {
                Console.WriteLine("border");
            }
            else
            {
                Console.WriteLine("outside");
            }
        }
    }
}
