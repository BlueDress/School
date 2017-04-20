using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmass_tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете n=");
            var n = int.Parse(Console.ReadLine());

            Console.Write(new string(' ', n));
            Console.WriteLine(" |");

            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string(' ', n - i));
                Console.Write(new string('*', i));
                Console.Write(" | ");
                Console.Write(new string('*', i));
                Console.WriteLine();
            }


        }
    }
}
