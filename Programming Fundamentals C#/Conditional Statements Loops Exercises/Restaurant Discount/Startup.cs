using System;

namespace Restaurant_Discount
{
    public class Startup
    {
        public static void Main()
        {
            var groupSize = int.Parse(Console.ReadLine());
            var package = Console.ReadLine();

            var hallName = string.Empty;
            var totalPrice = 0.0;

            if (0 < groupSize && groupSize <= 50)
            {
                hallName = "Small Hall";
                totalPrice = 2500;

                if (package.Equals("Normal"))
                {
                    totalPrice = (totalPrice + 500) * 0.95;
                }
                else if (package.Equals("Gold"))
                {
                    totalPrice = (totalPrice + 750) * 0.9;
                }
                else
                {
                    totalPrice = (totalPrice + 1000) * 0.85;
                }

                Console.WriteLine($"We can offer you the {hallName}");
                Console.WriteLine($"The price per person is {totalPrice / groupSize:f2}$");
            }
            else if (50 < groupSize && groupSize <= 100)
            {
                hallName = "Terrace";
                totalPrice = 5000;

                if (package.Equals("Normal"))
                {
                    totalPrice = (totalPrice + 500) * 0.95;
                }
                else if (package.Equals("Gold"))
                {
                    totalPrice = (totalPrice + 750) * 0.9;
                }
                else
                {
                    totalPrice = (totalPrice + 1000) * 0.85;
                }

                Console.WriteLine($"We can offer you the {hallName}");
                Console.WriteLine($"The price per person is {totalPrice / groupSize:f2}$");
            }
            else if (100 < groupSize && groupSize <= 120)
            {
                hallName = "Great Hall";
                totalPrice = 7500;

                if (package.Equals("Normal"))
                {
                    totalPrice = (totalPrice + 500) * 0.95;
                }
                else if (package.Equals("Gold"))
                {
                    totalPrice = (totalPrice + 750) * 0.9;
                }
                else
                {
                    totalPrice = (totalPrice + 1000) * 0.85;
                }

                Console.WriteLine($"We can offer you the {hallName}");
                Console.WriteLine($"The price per person is {totalPrice / groupSize:f2}$");
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}
