﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_on_the_border_of_a_rectangular
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете  стойност за x1 ");
            var x1 = double.Parse(Console.ReadLine());

            Console.Write("Въведете  стойност за y1 ");
            var y1 = double.Parse(Console.ReadLine());

            Console.Write("Въведете  стойност за x2 ");
            var x2 = double.Parse(Console.ReadLine());

            Console.Write("Въведете  стойност за y2 ");
            var y2 = double.Parse(Console.ReadLine());

            Console.Write("Въведете  стойност за x ");
            var x = double.Parse(Console.ReadLine());

            Console.Write("Въведете  стойност за y ");
            var y = double.Parse(Console.ReadLine());

            if ((((x == x1) || (x == x2)) && (y >= Math.Min(y1, y2) && y <= Math.Max(y1, y2))) || (((y == y1) || (y == y2)) && (x >= Math.Min(x1, x2) && x <= Math.Max(x1, x2))))
                Console.WriteLine("Border");
            else
                Console.WriteLine("Inside / Outside");
        }
    }
}
