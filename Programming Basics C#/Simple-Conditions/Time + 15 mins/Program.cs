using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time___15_mins
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете час ");
            var hh = int.Parse(Console.ReadLine());

            Console.Write("Въведете минути ");
            var mm = int.Parse(Console.ReadLine());

            var a = mm + 15;

            if (a <= 59)
            {
                Console.WriteLine($"След 15 минути ще бъде {hh}:{a} часа");
            }
            else if ((a > 59) && (hh < 23))
            {
                hh = hh + 1;
                a = a - 60;
                if (a < 10)
                {
                    Console.WriteLine($"След 15 минути ще бъде {hh}:0{a} часа");
                }
                else
                {
                    Console.WriteLine($"След 15 минути ще бъде {hh}:{a} часа");
                }
            }
            else
            {
                hh = 0;
                a = a - 60;
                if (a < 10)
                {
                    Console.WriteLine($"След 15 минути ще бъде {hh}:0{a} часа");
                }
                else
                {
                    Console.WriteLine($"След 15 минути ще бъде {hh}:{a} часа");
                }
            }              
        }
    }
}
