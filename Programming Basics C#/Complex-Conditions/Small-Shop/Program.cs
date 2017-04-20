using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете продукт ");
            var product = Console.ReadLine().ToLower();

            Console.Write("Въведете град ");
            var town = Console.ReadLine().ToLower();
            
            Console.Write("Въведете количество ");
            var quantity = double.Parse(Console.ReadLine());

            if (town == "Sofia")
            {
                if (product == "coffee")
                {
                    var a = quantity * 0.50;
                    Console.WriteLine($"Цената е {a}");
                }
                else if (product == "water")
                {
                    var a = quantity * 0.80;
                    Console.WriteLine($"Цената е {a}");
                }
                else if(product == "beer")
                {
                    var a = quantity * 1.20;
                    Console.WriteLine($"Цената е {a}");
                }
                else if (product == "sweets")
                {
                    var a = quantity * 1.45;
                    Console.WriteLine($"Цената е {a}");
                }
                else if (product == "peanuts")
                {
                    var a = quantity * 1.60;
                    Console.WriteLine($"Цената е {a}");
                }                
            }
            else if (town == "Plovdiv")
            {
                if (product == "coffee")
                {
                    var a = quantity * 0.40;
                    Console.WriteLine($"Цената е {a}");
                }
                else if (product == "water")
                {
                    var a = quantity * 0.70;
                    Console.WriteLine($"Цената е {a}");
                }
                else if (product == "beer")
                {
                    var a = quantity * 1.15;
                    Console.WriteLine($"Цената е {a}");
                }
                else if (product == "sweets")
                {
                    var a = quantity * 1.30;
                    Console.WriteLine($"Цената е {a}");
                }
                else if (product == "peanuts")
                {
                    var a = quantity * 1.50;
                    Console.WriteLine($"Цената е {a}");
                }
            }
            else if (town == "Varna")
            {
                if (product == "coffee")
                {
                    var a = quantity * 0.45;
                    Console.WriteLine($"Цената е {a}");
                }
                else if (product == "water")
                {
                    var a = quantity * 0.70;
                    Console.WriteLine($"Цената е {a}");
                }
                else if (product == "beer")
                {
                    var a = quantity * 1.10;
                    Console.WriteLine($"Цената е {a}");
                }
                else if (product == "sweets")
                {
                    var a = quantity * 1.35;
                    Console.WriteLine($"Цената е {a}");
                }
                else if (product == "peanuts")
                {
                    var a = quantity * 1.55;
                    Console.WriteLine($"Цената е {a}");
                }
            }
        }
    }
}
