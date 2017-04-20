using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number of people ");
            var n = int.Parse(Console.ReadLine());
            Console.Write("Capacity " );
            var p = int.Parse(Console.ReadLine());
            
            Console.WriteLine("{0}", Math.Ceiling((double)n / p));
        }
    }
}
