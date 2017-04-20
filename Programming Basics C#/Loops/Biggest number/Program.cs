using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biggest_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете брой числа ");
            var count = int.Parse(Console.ReadLine());

            var check = int.MinValue;

            for (int i = 0; i < count; i++)
            {
                Console.Write("Въведете число ");
                var num = int.Parse(Console.ReadLine());
                if (num > check)
                    check = num;
            }
            if (count <= 0)
            {
                Console.WriteLine("Трябва да въведете поне едно число за сравнение");
            }
            else
            {
                Console.WriteLine($"Най-голямото въведено число е {check}");
            }
        }
    }
}
