using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square
{
    class Square
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете брой редове ");
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('*', n + n - 1));

            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("*");

                Console.Write(new string(' ', n + n - 3));

                Console.WriteLine("*");
            }
            Console.WriteLine(new string('*', n + n - 1));
        }
    }
}
