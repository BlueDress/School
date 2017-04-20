using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Earnings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете броя на работните дни в месеца ");
            var days = int.Parse(Console.ReadLine());

            Console.Write("Въведете заплащане на ден ");
            var moneyperday = double.Parse(Console.ReadLine());

            Console.Write("Въведете курс на долара спрямо лева ");
            var USDtoBGN = double.Parse(Console.ReadLine());

            var profitperday = Math.Round(((((days * moneyperday) * 14.5) - ((25 * ((days * moneyperday) * 14.5)) / 100)) / 365) * USDtoBGN, 2);
            Console.WriteLine($"При {days} работни дни на месец и {moneyperday}$ средно заплащане на ден, и курс на долара спрямо лева {USDtoBGN}, получавате {profitperday} лева на ден чиста печалба");

        }
    }
}
