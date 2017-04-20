using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете число ");
            var num = int.Parse(Console.ReadLine());
            double bp = 0;

            if (num <= 100)
            {
                bp = bp + 5;
            }
            else if (num > 100)
            {
                bp = num / 5;
            }
            if (num > 1000)
            {
                bp = (bp * 0 ) + (num / 10);
            }
            
            if (num % 2 == 0)
            {
                bp = bp + 1;
            }
            else if (num % 5 == 0)
            {
                bp = bp + 2;
            }

            var sum = num + bp;
            Console.WriteLine($"Бонус точките са {bp}, а сумата им с числото е {sum}");
        }
    }
}
