﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_in_Reversed_Order
{
    class Program
    {
        public static void ReversNumbers(string number)
        {
            for (int i = number.Length - 1; i >= 0; i--)
            {
                Console.Write(number[i]);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            ReversNumbers(number);
        }
    }
}
