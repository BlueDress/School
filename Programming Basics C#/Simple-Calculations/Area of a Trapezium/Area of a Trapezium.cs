using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_a_Trapezium
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете дължина на долната основа ");
            var a = double.Parse(Console.ReadLine());
            Console.Write("Въведете дължина на горната  основа ");
            var b = double.Parse(Console.ReadLine());
            Console.Write("Въведете дължина на височината ");
            var h = double.Parse(Console.ReadLine());
            var area = ((a + b) * h) / 2;
            Console.WriteLine($"Лицето на трапеца е {area}");
        }
    }
}
