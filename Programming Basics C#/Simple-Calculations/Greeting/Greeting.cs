using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeting
{
    class Greeting
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете името си ");
            var name = Console.ReadLine();
            Console.WriteLine($"Здравей, {name}!!!");

        }
    }
}
