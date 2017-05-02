using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_and_Perimeter_of_a_Circle
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.Write("Въведете радиуса на окръжността ");
            var r = double.Parse(Console.ReadLine());
            var per = 2 * Math.PI * r;
            var area = Math.PI * r * r;
            Console.WriteLine(Math.Round(area,4));
            Console.WriteLine(Math.Round(per,4));
        }
    }
}
