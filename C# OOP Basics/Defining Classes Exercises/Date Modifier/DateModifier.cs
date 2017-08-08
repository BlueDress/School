

using System;
using System.Globalization;

namespace Date_Modifier
{
    public class DateModifier
    {
        public double CalculateDifferenceBetweenTwoDates(string firstDate, string secondDate)
        {
            var dateOne = DateTime.ParseExact(firstDate, "yyyy MM dd", CultureInfo.InvariantCulture);
            var dateTwo = DateTime.ParseExact(secondDate, "yyyy MM dd", CultureInfo.InvariantCulture);

            var differenceInDays = dateOne.Subtract(dateTwo).TotalDays;
            return Math.Abs(differenceInDays);
        }
    }
}
