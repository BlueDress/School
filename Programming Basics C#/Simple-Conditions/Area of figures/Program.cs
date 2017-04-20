using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_figures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете вид на геометричната фигура ");
            var figure = Console.ReadLine();
            double s = 0;

            if (figure == "square")
            {
                Console.Write("Въведете страна на квадрата ");
                var a = double.Parse(Console.ReadLine());
                s = Math.Round(a * a, 3);
                Console.WriteLine($"Лицето на квадрата е {s}");
            }
            else if (figure == "rectangle")
            {
                Console.Write("Въведете едната страна на правоъгълника ");
                var a = double.Parse(Console.ReadLine());
                Console.Write("Въведете другата страна на правоъгълника ");
                var b = double.Parse(Console.ReadLine());
                s = Math.Round(a * b, 3);
                Console.WriteLine($"Лицето на правоъгълника е {s}");
            }
            else if (figure == "circle")
            {
                Console.Write("Въведете радиуса на кръга ");
                var a = double.Parse(Console.ReadLine());
                s = Math.Round(a * a * Math.PI, 3);
                Console.WriteLine($"Лицето на кръга е {s}");
            }
            else if (figure == "triangle")
            {
                Console.Write("Въведете страна на триъгълника ");
                var a = double.Parse(Console.ReadLine());
                Console.Write("Въведете височината към страната на триъгълника ");
                var h = double.Parse(Console.ReadLine());
                s = Math.Round((a * h) / 2, 3);
                Console.WriteLine($"Лицето на триъгълника е {s}");
            }            
        }
    }
}
