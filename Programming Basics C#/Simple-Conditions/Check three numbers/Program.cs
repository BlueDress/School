using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_three_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете първото число ");
            var a = int.Parse(Console.ReadLine());

            Console.Write("Въведете второто число ");
            var b = int.Parse(Console.ReadLine());

            Console.Write("Въведете третото число ");
            var c = int.Parse(Console.ReadLine());

            if ((a == b) && (b == c))
            {
                Console.WriteLine("Числата са еднакви");
            }
            else
            {
                Console.WriteLine("Числата са различни");
            }
        }
    }
}
