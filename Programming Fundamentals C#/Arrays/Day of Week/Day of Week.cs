using System;
namespace Day_of_Week
{
    class DayOfWeek
    {
        static void Main()
        {
            var DayOfWeek = new string[] {"Monday", "Tuesday" ,"Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
            var n = int.Parse(Console.ReadLine());
            if (n > 0 && n < 8)
            {
                Console.WriteLine(DayOfWeek[n - 1]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}
