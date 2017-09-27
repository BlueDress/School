using System;

namespace Hotel
{
    public class Startup
    {
        public static void Main()
        {
            var month = Console.ReadLine();
            var nightsCount = int.Parse(Console.ReadLine());

            if (month == "May" || month == "October")
            {
                if (nightsCount >= 0 && nightsCount <= 7)
                {
                    Console.WriteLine($"Studio: {nightsCount * 50:f2} lv.");
                }
                else
                {
                    if (month == "May")
                    {
                        Console.WriteLine($"Studio: {(nightsCount * 50) * 0.95:f2} lv.");
                    }
                    else
                    {
                        Console.WriteLine($"Studio: {((nightsCount - 1) * 50) * 0.95:f2} lv.");
                    }
                }
                Console.WriteLine($"Double: {nightsCount * 65:f2} lv.");
                Console.WriteLine($"Suite: {nightsCount * 75:f2} lv.");
            }
            else if (month == "June" || month == "September")
            {
                if (nightsCount >= 0 && nightsCount <= 7)
                {
                    Console.WriteLine($"Studio: {nightsCount * 60:f2} lv.");
                }
                else
                {
                    if (month == "June")
                    {
                        Console.WriteLine($"Studio: {nightsCount * 60:f2} lv.");
                    }
                    else
                    {
                        Console.WriteLine($"Studio: {(nightsCount - 1) * 60:f2} lv.");
                    }
                }

                if (nightsCount >= 0 && nightsCount <= 14)
                {
                    Console.WriteLine($"Double: {nightsCount * 72:f2} lv.");
                }
                else if (nightsCount > 14)
                {
                    Console.WriteLine($"Double: {(nightsCount * 72) * 0.90:f2} lv.");
                }

                Console.WriteLine($"Suite: {nightsCount * 82:f2} lv.");
            }
            else
            {
                Console.WriteLine($"Studio: {nightsCount * 68:f2} lv.");
                Console.WriteLine($"Double: {nightsCount * 77:f2} lv.");

                if (nightsCount >= 0 && nightsCount <= 14)
                {
                    Console.WriteLine($"Suite: {nightsCount * 89:f2} lv.");
                }
                else if (nightsCount > 14)
                {
                    Console.WriteLine($"Suite: {(nightsCount * 89) * 0.85:f2} lv.");
                }
            }
        }
    }
}
