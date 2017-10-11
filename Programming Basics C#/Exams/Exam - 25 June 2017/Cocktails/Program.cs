using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails
{
    class Program
    {
        static void Main(string[] args)
        {
            var fruit = Console.ReadLine();
            var type = Console.ReadLine();
            var drinks = int.Parse(Console.ReadLine());

            var price = 0d;

            if (type.Equals("small"))
            {
                switch (fruit)
                {
                    case "Watermelon":
                        price = 2 * 56 * drinks;
                        break;
                    case "Mango":
                        price = 2 * 36.66 * drinks;
                        break;
                    case "Pineapple":
                        price = 2 * 42.10 * drinks;
                        break;
                    case "Raspberry":
                        price = 2 * 20 * drinks;
                        break;
                }
            }
            else
            {
                switch (fruit)
                {
                    case "Watermelon":
                        price = 5 * 28.70 * drinks;
                        break;
                    case "Mango":
                        price = 5 * 19.60 * drinks;
                        break;
                    case "Pineapple":
                        price = 5 * 24.80 * drinks;
                        break;
                    case "Raspberry":
                        price = 5 * 15.20 * drinks;
                        break;
                }
            }

            var totalPrice = 0d;

            if (price > 1000)
            {
                totalPrice = price - (price * 0.50);
            }
            else if (price >= 400)
            {
                totalPrice = price - (price * 0.15);
            }
            else
            {
                totalPrice = price;
            }

            Console.WriteLine($"{totalPrice:f2} lv.");
        }
    }
}
