using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_room
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Изберете месец ");
            var month = Console.ReadLine();

            Console.Write("Въведете брой нощувки ");
            var num = int.Parse(Console.ReadLine());

            if (month == "May" || month == "October")
            {
                if (num >= 0 && num <= 7)
                {
                    Console.WriteLine($"Apartment {num * 65:f2} leva");
                    Console.WriteLine($"Studio {num * 50:f2} leva");
                }
                else if (num > 7 && num <= 14)
                {
                    Console.WriteLine($"Apartment : {num * 65:f2} leva");
                    Console.WriteLine($"Studio : {(num * 50) * 0.95:f2} leva");
                }
                else if (num > 14)
                {
                    Console.WriteLine($"Apartment : {(num * 65) * 0.90:f2} leva");
                    Console.WriteLine($"Studio : {(num * 50) * 0.70:f2} leva");
                }
            }
            else if (month == "June" || month == "September")
            {
                if (num >= 0 && num <= 14)
                {
                    Console.WriteLine($"Apartment : {num * 68.70:f2} leva");
                    Console.WriteLine($"Studio : {num * 75.20:f2} leva");
                }
                else if (num > 14)
                {
                    Console.WriteLine($"Apartment : {(num * 68.70) * 0.90:f2} leva");
                    Console.WriteLine($"Studio : {(num * 75.20) * 0.80:f2} leva");
                }
            }
            else
            {
                if (num >= 0 && num <= 14)
                {
                    Console.WriteLine($"Apartment : {num * 77:f2} leva");
                    Console.WriteLine($"Studio : {num * 76:f2} leva");
                }
                else if (num > 14)
                {
                    Console.WriteLine($"Apartment : {(num * 77) * 0.90:f2} leva");
                    Console.WriteLine($"Studio : {num * 76:f2} leva");
                }
            }
        }
    }
}
