using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commissions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете град ");
            var town = Console.ReadLine().ToLower();
            
            Console.Write("Обем на продажби ");
            var sales = double.Parse(Console.ReadLine());

            var Commission = -1.0;

            if (town == "sofia")
            {
                if (0 <= sales && sales <= 500) Commission = 0.05;
                if (500 < sales && sales <= 1000) Commission = 0.07;
                if (1000 < sales && sales <= 10000) Commission = 0.08;
                if (10000 < sales) Commission = 0.12;
            }
            else if (town == "varna")
            {
                if (0 <= sales && sales <= 500) Commission = 0.045;
                if (500 < sales && sales <= 1000) Commission = 0.075;
                if (1000 < sales && sales <= 10000) Commission = 0.10;
                if (10000 < sales) Commission = 0.13;
            }
            else if (town == "plovdiv")
            {
                if (0 <= sales && sales <= 500) Commission = 0.055;
                if (500 < sales && sales <= 1000) Commission = 0.08;
                if (1000 < sales && sales <= 10000) Commission = 0.12;
                if (10000 < sales) Commission = 0.145;
            }

            if (Commission >= 0)
            {
                Console.WriteLine("{0:f2}", sales * Commission);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
