using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Ch11P09
{
    public class Startup
    {
        public static void Main()
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            DateTime startDate = DateTime.ParseExact(firstDate, "d-M-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(secondDate, "d-M-yyyy", CultureInfo.InvariantCulture);

            List<DateTime> holidays = new List<DateTime>()
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

            int workDaysCount = 0;
            
            for (DateTime i = startDate; i <= endDate; i = i.AddDays(1))
            {
                int day = i.Day;
                int month = i.Month;

                if (i.DayOfWeek != DayOfWeek.Saturday && i.DayOfWeek != DayOfWeek.Sunday && !holidays.Any(date => date.Day == day && date.Month == month))
                {
                    workDaysCount++;
                }
            }

            Console.WriteLine(workDaysCount);
        }
    }
}
