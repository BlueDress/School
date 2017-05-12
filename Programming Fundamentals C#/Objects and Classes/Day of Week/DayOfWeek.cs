using System;
using System.Globalization;

namespace Day_of_Week
{
    public class DayOfWeek
    {
        public static void Main()
        {
            var inputDate = Console.ReadLine();
            var date = DateTime.ParseExact(inputDate, "d-M-yyyy", CultureInfo.InvariantCulture);
            var dayOfWeek = date.DayOfWeek;
            Console.WriteLine(dayOfWeek);
        }
    }
}
