using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете брой числа ");
            var count = int.Parse(Console.ReadLine());
            var sum = 0;

            for (int i = 1; i <= count; i++)
            {
                Console.Write("Въведете число ");
                var num = int.Parse(Console.ReadLine());
                sum = sum + num;
            }
            Console.WriteLine($"Сумата е {sum}");
        }
    }
}
