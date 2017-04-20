using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price_of_Transportation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете колко километра изминава студента ");
            var dist = int.Parse(Console.ReadLine());

            Console.Write("Въведете през кое време на денонощието пътува студента ");
            var time = Console.ReadLine();

            double bestprice = 0;

            if (dist < 20)
            {
                if (time == "day")
                {
                    bestprice = ((dist * 0.79) + 0.70);
                    Console.WriteLine($"Най-ниската цена за транспорт е {bestprice} лева");
                }
                else if (time == "night")
                {
                    bestprice = ((dist * 0.90) + 0.70);
                    Console.WriteLine($"Най-ниската цена за транспорт е {bestprice} лева");
                }
            }
            else if ((dist >= 20) && (dist < 100))
            {
                bestprice = dist * 0.09;
                Console.WriteLine($"Най-ниската цена за транспорт е {bestprice} лева");
            }
            else if (dist >= 100)
            {
                bestprice = dist * 0.06;
                Console.WriteLine($"Най-ниската цена за транспорт е {bestprice} лева");
            } 
        }
    }
}

