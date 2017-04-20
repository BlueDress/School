using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangular
{
    class Rectangular
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете брой звезди ");
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('*', n));

            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("*");
                
                Console.Write(new string(' ', n -2));
                
                Console.WriteLine("*");
            }
            Console.WriteLine(new string('*', n));
        }
    }
}
