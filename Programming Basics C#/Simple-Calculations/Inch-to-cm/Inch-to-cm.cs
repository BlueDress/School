using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inch_to_cm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете дължина в инчове ");
            var a = double.Parse(Console.ReadLine());
            var result = a * 2.54;
            Console.WriteLine($"{a} инча са равни на {result} сантиметра");
        }
    }
}
