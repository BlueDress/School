using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете бюджет ");
            var sum = double.Parse(Console.ReadLine());

            Console.Write("Изберете категория ");
            var cat = Console.ReadLine();

            Console.Write("Въведете брой на хората ");
            var num = int.Parse(Console.ReadLine());

            var left = 0.0;
            var ndd = 0.0;

            if (cat == "VIP")
            {
                if (num >= 1 && num <= 4)
                {
                    left = sum * 0.25;
                    ndd = num * 499.99;
                }
                else if (num >= 1 && num <= 4)
                {
                    left = sum * 0.25;
                    ndd = num * 499.99;
                }
                else if (num >= 5 && num <= 9)
                {
                    left = sum * 0.4;
                    ndd = num * 499.99;
                }
                else if (num >= 10 && num <= 24)
                {
                    left = sum * 0.5;
                    ndd = num * 499.99;
                }
                else if (num >= 24 && num <= 49)
                {
                    left = sum * 0.6;
                    ndd = num * 499.99;
                }
                else
                {
                    left = sum * 0.75;
                    ndd = num * 499.99;
                }
            }
            else
            {
                if (num >= 1 && num <= 4)
                {
                    left = sum * 0.25;
                    ndd = num * 249.99;
                }
                else if (num >= 1 && num <= 4)
                {
                    left = sum * 0.25;
                    ndd = num * 249.99;
                }
                else if (num >= 5 && num <= 9)
                {
                    left = sum * 0.4;
                    ndd = num * 249.99;
                }
                else if (num >= 10 && num <= 24)
                {
                    left = sum * 0.5;
                    ndd = num * 249.99;
                }
                else if (num >= 24 && num <= 49)
                {
                    left = sum * 0.6;
                    ndd = num * 249.99;
                }
                else
                {
                    left = sum * 0.75;
                    ndd = num * 249.99;
                }
            }
            if (left >= ndd)
            {
                Console.WriteLine($"Yes! You have {left - ndd:f2} leva left");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {ndd - left:f2} leva");
            }
        }
    }
}
