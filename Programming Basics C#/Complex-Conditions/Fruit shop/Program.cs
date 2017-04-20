using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit_shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете плод ");
            var fruit = Console.ReadLine().ToLower();

            Console.Write("Въведете ден ");
            var day = Console.ReadLine().ToLower();

            Console.Write("Въведете количество ");
            var quantity = double.Parse(Console.ReadLine());

            if (day == "monday" || day == "tuesday" || day == "wednesday" || day =="thursday" || day == "friday")
            {
                if (fruit == "banana")
                {
                    var a = Math.Round(quantity * 2.50, 2);
                    Console.WriteLine($"{a}");
                }
                else if (fruit == "apple")
                {
                    var a = Math.Round(quantity * 1.20, 2);
                    Console.WriteLine($"{a}");
                }
                else if (fruit == "orange")
                {
                    var a = Math.Round(quantity * 0.85, 2);
                    Console.WriteLine($"{a}");
                }
                else if (fruit == "grapefruit")
                {
                    var a = Math.Round(quantity * 1.45, 2);
                    Console.WriteLine($"{a}");
                }
                else if (fruit == "kiwi")
                {
                    var a = Math.Round(quantity * 2.70, 2);
                    Console.WriteLine($"{a}");
                }
                else if (fruit == "pineapple")
                {
                    var a = Math.Round(quantity * 5.50, 2);
                    Console.WriteLine($"{a}");
                }
                else if (fruit == "grapes")
                {
                    var a = Math.Round(quantity * 3.85, 2);
                    Console.WriteLine($"{a}");
                }
                else
                {
                    Console.WriteLine("error");
                }               
            }
            else if (day == "saturday" || day == "sunday")
            {
                if (fruit == "banana")
                {
                    var a = Math.Round(quantity * 2.70, 2);
                    Console.WriteLine($"{a}");
                }
                else if (fruit == "apple")
                {
                    var a = Math.Round(quantity * 1.25, 2);
                    Console.WriteLine($"{a}");
                }
                else if (fruit == "orange")
                {
                    var a = Math.Round(quantity * 0.90, 2);
                    Console.WriteLine($"{a}");
                }
                else if (fruit == "grapefruit")
                {
                    var a = Math.Round(quantity * 1.60, 2);
                    Console.WriteLine($"{a}");
                }
                else if (fruit == "kiwi")
                {
                    var a = Math.Round(quantity * 3.00, 2);
                    Console.WriteLine($"{a}");
                }
                else if (fruit == "pineapple")
                {
                    var a = Math.Round(quantity * 5.60, 2);
                    Console.WriteLine($"{a}");
                }
                else if (fruit == "grapes")
                {
                    var a = Math.Round(quantity * 4.20, 2);
                    Console.WriteLine($"{a}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
