using System;

namespace Hornet_Wings
{
    public class HornetWings
    {
        public static void Main()
        {
            var numberOfWingFlaps = int.Parse(Console.ReadLine());
            var distanceForThousandWingFlaps = double.Parse(Console.ReadLine());
            var endurance = int.Parse(Console.ReadLine());

            var metersTraveled = distanceForThousandWingFlaps / 1000 * numberOfWingFlaps;
            double secondsFlying = numberOfWingFlaps / 100;
            var secondsResting = numberOfWingFlaps / endurance * 5;
            var totalSeconds = secondsFlying + secondsResting;

            Console.WriteLine($"{metersTraveled:f2} m.");
            Console.WriteLine($"{totalSeconds} s.");
        }
    }
}
