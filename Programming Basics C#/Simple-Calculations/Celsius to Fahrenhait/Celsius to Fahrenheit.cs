using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celsius_to_Fahrenhait
{
    class Program
    {
        static void Main(string[] args)
        {
          //  Console.Write("Въведи градуси по Целзии ");
            var c = double.Parse(Console.ReadLine());
            var f = c * 1.8 + 32;
            Console.WriteLine(Math.Round(f, 2));
        }
    }
}
