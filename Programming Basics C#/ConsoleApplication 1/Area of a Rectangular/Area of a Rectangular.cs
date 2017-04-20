using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_a_Rectangular
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи стойността на първата страна ");
            var a = decimal.Parse(Console.ReadLine());
            Console.Write("Въведи стойността на втората страна ");
            var b = decimal.Parse(Console.ReadLine());
            Console.Write("Лицето на правоъгълника е равно на ");
            Console.WriteLine(a * b);
        }
    }
}
