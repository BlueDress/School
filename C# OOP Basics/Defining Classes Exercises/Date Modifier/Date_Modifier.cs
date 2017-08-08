using System;

namespace Date_Modifier
{
    public class Date_Modifier
    {
        public static void Main()
        {
            var firstDate = Console.ReadLine();
            var secondDate = Console.ReadLine();

            var difference = new DateModifier();
            Console.WriteLine(difference.CalculateDifferenceBetweenTwoDates(firstDate, secondDate));
        }
    }
}
