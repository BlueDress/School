using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seconds_Calculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи времето на първия състезател ");
            var firsttime = int.Parse(Console.ReadLine());
            
            Console.Write("Въведи времето на втория състезател ");
            var secondtime = int.Parse(Console.ReadLine());

            Console.Write("Въведи времето на трития състезател ");
            var thirdtime = int.Parse(Console.ReadLine());

            var sum = firsttime + secondtime + thirdtime;

            var mins = sum / 60;
            var secs = sum % 60;
            
            if (sum < 60)
            {
                if (secs < 10)
                {
                    Console.WriteLine($"Сумарното време на тримата състезатели е {mins}:0{secs}");
                }
                else
                {
                    Console.WriteLine($"Сумарното време на тримата състезатели е {mins}:{secs}");
                }
            }
            else if ((sum > 59) && (sum <119))
                {
                if (secs < 10)
                {
                    Console.WriteLine($"Сумарното време на тримата състезатели е {mins}:0{secs}");
                }
                else
                {
                    Console.WriteLine($"Сумарното време на тримата състезатели е {mins}:{secs}");
                }
                }
            else
            {
                if (secs < 10)
                {
                    Console.WriteLine($"Сумарното време на тримата състезатели е {mins}:0{secs}");
                }
                else
                {
                    Console.WriteLine($"Сумарното време на тримата състезатели е {mins}:{secs}");
                }
            }
        }
    }
}
