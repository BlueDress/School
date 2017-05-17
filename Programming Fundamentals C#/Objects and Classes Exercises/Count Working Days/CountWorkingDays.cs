using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Count_Working_Days
{
    public class CountWorkingDays
    {
        public static void Main()
        {
            var firstDate = Console.ReadLine();
            var secondDate = Console.ReadLine();

            var startDate = DateTime.ParseExact(firstDate, "d-M-yyyy", CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact(secondDate, "d-M-yyyy", CultureInfo.InvariantCulture);

            var holidays = new List<DateTime>()
            {
            new DateTime(startDate.Year, 01, 01),
            new DateTime(startDate.Year, 03, 03),
            new DateTime(startDate.Year, 05, 01),
            new DateTime(startDate.Year, 05, 06),
            new DateTime(startDate.Year, 05, 24),
            new DateTime(startDate.Year, 09, 06),
            new DateTime(startDate.Year, 09, 22),
            new DateTime(startDate.Year, 11, 01),
            new DateTime(startDate.Year, 12, 24),
            new DateTime(startDate.Year, 12, 25),
            new DateTime(startDate.Year, 12, 26),
            };

            var workDaysCount = 0;


            for (var i = startDate; i <= endDate; i = i.AddDays(1))
            {
                var day = i.Day;
                var month = i.Month;
                if (i.DayOfWeek != DayOfWeek.Saturday && i.DayOfWeek != DayOfWeek.Sunday && !holidays.Any(date => date.Day == day && date.Month == month))
                {
                    workDaysCount++;
                }
            }
            Console.WriteLine(workDaysCount);
        }
    }
}
