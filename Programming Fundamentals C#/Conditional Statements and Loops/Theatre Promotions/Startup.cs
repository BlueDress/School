using System;

namespace Theatre_Promotions
{
    public class Startup
    {
        public static void Main()
        {
            var day = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());

            if (age < 0 || 122 < age)
            {
                Console.WriteLine("Error!");
            }
            else if (0 <= age && age <= 18)
            {
                if (day.Equals("Weekday"))
                {
                    Console.WriteLine("12$");
                }
                else if (day.Equals("Weekend"))
                {
                    Console.WriteLine("15$");
                }
                else
                {
                    Console.WriteLine("5$");
                }
            }
            else if (18 < age && age <= 64)
            {
                if (day.Equals("Weekday"))
                {
                    Console.WriteLine("18$");
                }
                else if (day.Equals("Weekend"))
                {
                    Console.WriteLine("20$");
                }
                else
                {
                    Console.WriteLine("12$");
                }
            }
            else
            {
                if (day.Equals("Weekday"))
                {
                    Console.WriteLine("12$");
                }
                else if (day.Equals("Weekend"))
                {
                    Console.WriteLine("15$");
                }
                else
                {
                    Console.WriteLine("10$");
                }
            }
        }
    }
}
