using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centuries_to_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете векове ");
            var n = int.Parse(Console.ReadLine());
            var y = n * 100;
            var d = (int)(y * 365.2422);
            var h = d * 24;
            var m = h * 60;

            Console.WriteLine($"{n} centuries = {y} years = {d} days = {h} hours = {m} minutes");
        }
    }
}
