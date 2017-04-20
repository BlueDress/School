using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolleyBall
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Вид година ");
            var year = Console.ReadLine();

            Console.Write("Брой празници ");
            var p = int.Parse(Console.ReadLine());

            Console.Write("Брой уикенди ");
            var h = int.Parse(Console.ReadLine());

            var nyear = h + ((3.0 * (48 - h)) / 4) + ((2 * p) / 3);
            var lyear = nyear + nyear * 0.15;

            switch(year)
            {
                case "normal": Console.WriteLine("{0}", Math.Floor(nyear)); break;
                case "leap": Console.WriteLine("{0}", Math.Floor(lyear)); break;

            }
        }
    }
}
