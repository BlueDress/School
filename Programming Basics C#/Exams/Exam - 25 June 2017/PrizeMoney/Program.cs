using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizeMoney
{
    class Program
    {
        static void Main(string[] args)
        {
            var parts = int.Parse(Console.ReadLine());
            var moneyForOnePoint = double.Parse(Console.ReadLine());

            var sum = 0d;

            for (int i = 1; i <= parts; i++)
            {
                var points = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    sum += 2 * points;
                }
                else
                {
                    sum += points;
                }
            }

            var prize = sum * moneyForOnePoint;

            Console.WriteLine($"The project prize was {prize:f2} lv.");
        }
    }
}
