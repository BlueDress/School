﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            string boolean = Console.ReadLine();
            if (Convert.ToBoolean(boolean) == true) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
    }
}
