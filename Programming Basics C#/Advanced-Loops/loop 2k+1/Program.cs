﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете число ");
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i = 2 * i + 1)
            {
                Console.WriteLine(i);
            }
        }
    }
}
