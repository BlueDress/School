using System;
using System.Collections.Generic;

namespace Month_Printer
{
    public class Startup
    {
        public static void Main()
        {
            var months = new Dictionary<int, string>();

            months.Add(1, "January");
            months.Add(2, "February");
            months.Add(3, "March");
            months.Add(4, "April");
            months.Add(5, "May");
            months.Add(6, "June");
            months.Add(7, "July");
            months.Add(8, "August");
            months.Add(9, "September");
            months.Add(10, "October");
            months.Add(11, "November");
            months.Add(12, "December");

            var number = int.Parse(Console.ReadLine());

            if (months.ContainsKey(number))
            {
                Console.WriteLine(months[number]);
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
