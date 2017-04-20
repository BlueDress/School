using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power_of_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете число ");
            var n = int.Parse(Console.ReadLine());
            var num = 1;

            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(num);
                num *= 2;
            }
        }
    }
}
