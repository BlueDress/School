﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine($"Before: \na = {a} \nb = {b}" );

            int olda = a;
            a = b;
            b = olda;
            Console.WriteLine($"After: \na = {a} \nb = {b}");
        }
    }
}
