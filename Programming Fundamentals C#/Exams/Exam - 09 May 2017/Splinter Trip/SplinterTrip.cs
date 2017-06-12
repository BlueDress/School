using System;

namespace Splinter_Trip
{
    public class SplinterTrip
    {
        public static void Main()
        {
            var travelDistance = double.Parse(Console.ReadLine());
            var fuelTankCapacity = double.Parse(Console.ReadLine());
            var milesInHeavyWinds = double.Parse(Console.ReadLine());

            var milesNotInHeavyWinds = travelDistance - milesInHeavyWinds;

            var totalFuelNeeded = (milesNotInHeavyWinds * 25 + milesInHeavyWinds * 25 * 1.5) * 1.05;

            Console.WriteLine($"Fuel needed: {totalFuelNeeded:f2}L");

            if (totalFuelNeeded <= fuelTankCapacity)
            {
                Console.WriteLine($"Enough with {fuelTankCapacity - totalFuelNeeded:f2}L to spare!");
            }
            else
            {
                Console.WriteLine($"We need {totalFuelNeeded - fuelTankCapacity:f2}L more fuel.");
            }
        }
    }
}
