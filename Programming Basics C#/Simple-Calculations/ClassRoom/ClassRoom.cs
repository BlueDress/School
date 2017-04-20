using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class ClassRoom
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете дължина в метри ");
            var h = double.Parse(Console.ReadLine());
            Console.Write("Въведете широчина в метри ");
            var w = double.Parse(Console.ReadLine());

            Console.WriteLine();

            var rowh = Math.Floor(h / 1.2);
            var roww = Math.Floor((w - 1) / 0.7);
            var seatscount = (rowh * roww) - 3;
         
            Console.WriteLine($"В залата могат да се поместят {seatscount} места");
        }
    }
}
