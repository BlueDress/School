using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charity_Event
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var bakers = int.Parse(Console.ReadLine());
            var cakes = int.Parse(Console.ReadLine());
            var waffels = int.Parse(Console.ReadLine());
            var pancakes = int.Parse(Console.ReadLine());

            var sumForOneDay = (cakes * 45 + waffels * 5.8 + pancakes * 3.2) * bakers;
            var sumForAllDays = sumForOneDay * days;

            var sumAfterExpences = sumForAllDays - sumForAllDays / 8;

            Console.WriteLine($"{sumAfterExpences:f2}");
        }
    }
}
