using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repair
{
    class Repair
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете дължината на страната на площадката ");
            var area = double.Parse(Console.ReadLine());

            Console.Write("Въведете широчината на една плочка ");
            var wtile = double.Parse(Console.ReadLine());

            Console.Write("Въведете дължината на една плочка ");
            var htile = double.Parse(Console.ReadLine());

            Console.Write("Въведете широчината пейката ");
            var wbench = double.Parse(Console.ReadLine());

            Console.Write("Въведете дължината пейката ");
            var hbench = double.Parse(Console.ReadLine());

            var tiles = ((area * area) - (wbench * hbench)) / (wtile * htile);
            var time = tiles * 0.2;
            Console.WriteLine($"За покриване на площадката са нужни {tiles}, а необходимото веме за поставянето им е {time} минути");
        }
    }
}
