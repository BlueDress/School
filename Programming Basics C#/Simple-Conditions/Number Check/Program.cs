using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете число ");
            var num = int.Parse(Console.ReadLine());

            if (num < 100)
            {
                Console.WriteLine("Числото е по-малко от 100");
            }
            else if ((num >= 100) && (num <= 200))
            {
                Console.WriteLine("Числото е между 100 и 200");
            }
            else
            {
                Console.WriteLine("Числото е по-голямо от 200");
            }
        }
    }
}
