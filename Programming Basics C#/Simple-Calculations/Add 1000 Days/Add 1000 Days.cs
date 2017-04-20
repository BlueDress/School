using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_1000_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            var date = Console.ReadLine();
            string format = "dd-MM-yyyy";

            var resultingdate = DateTime.ParseExact(date, format, null);
            resultingdate = resultingdate.AddDays(999);

            var day = resultingdate.Day;
            var month = resultingdate.Month;
            var year = resultingdate.Year;
            Console.WriteLine($"{day}-{month}-{year}");
        }
    }
}
