using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете първото число ");
            var a = double.Parse(Console.ReadLine());

            Console.Write("Въведете второто число ");
            var b = double.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine($"Първото число е по-голямо {a} > {b}");
            }
            else if (a < b)
            {
                Console.WriteLine($"Второто число е по-голямо {b} > {a}");
            }
            else
            {
                Console.WriteLine($"Числата са равни {a} = {b}");
            }
        }
    }
}
