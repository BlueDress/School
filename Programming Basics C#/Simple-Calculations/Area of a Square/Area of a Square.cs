using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_a_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете дължина на страната ");
            var a = decimal.Parse(Console.ReadLine());
            var area = a * a;
            Console.Write("Лицето на квадрата е ");
            Console.WriteLine(area);
        }
    }
}
