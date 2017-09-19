using System;

namespace Miles_to_Kilometers
{
    public class Startup
    {
        public static void Main()
        {
            var distanceInMiles = double.Parse(Console.ReadLine());

            var distanceInKilometers = distanceInMiles * 1.60934;

            Console.WriteLine($"{distanceInKilometers:f2}");
        }
    }
}
