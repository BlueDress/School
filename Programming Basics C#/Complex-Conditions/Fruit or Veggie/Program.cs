using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit_or_Veggie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете плод или зеленчук ");
            var food = Console.ReadLine();

            if (food == "banana" || food == "apple" || food == "kiwi" || food == "cherry" || food == "lemon" || food == "grapes")
            {
                Console.WriteLine("It is a fruit");
            }
            else if (food == "tomato" || food == "cucumber" || food == "pepper" || food == "carrot")
            {
                Console.WriteLine("It is a veggie");
            }
            else
            {
                Console.WriteLine("Unknown food");
            }
        }
    }
}
