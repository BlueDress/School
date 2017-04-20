using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roadtrip
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи бюджет ");
            var sum = double.Parse(Console.ReadLine());

            Console.Write("Избери сезон ");
            var season = Console.ReadLine().ToLower();

            if (sum <= 100)
            {
                Console.WriteLine("Someware in Bulgaria");
                if (season == "summer")
                {
                    Console.WriteLine($"Camp - {sum * 0.30:f2}");
                }
                else
                {
                    Console.WriteLine($"Hotel - {sum * 0.70:f2}");
                }
            }
            else if (sum > 100 && sum <= 1000)
            {
                Console.WriteLine("Someware in Balkans");
                if (season == "summer")
                {
                    Console.WriteLine($"Camp - {sum * 0.40:f2}");
                }
                else
                {
                    Console.WriteLine($"Hotel - {sum * 0.80:f2}");
                }
            }
            else
            {
                Console.WriteLine("Someware in Europe");
                Console.WriteLine($"Hotel - {sum * 0.90:f2}");
            }
        }
    }
}
