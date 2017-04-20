using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radians_to_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи големина на ъгъла по радиани ");
            var rad = double.Parse(Console.ReadLine());
            var deg = (rad * 180) / Math.PI;
            Console.WriteLine($"{rad} радиана са равни на {Math.Round(deg)} градуса");
        }
    }
}
