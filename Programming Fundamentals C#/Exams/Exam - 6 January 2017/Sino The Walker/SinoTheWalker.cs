using System;
using System.Globalization;

namespace Sino_The_Walker
{
    public class SinoTheWalker
    {
        public static void Main()
        {
            var startTimeInput = Console.ReadLine();
            var startTime = DateTime.ParseExact(startTimeInput, "HH:mm:ss", CultureInfo.InvariantCulture);

            var numberOfSteps = int.Parse(Console.ReadLine());
            var secsPerStep = int.Parse(Console.ReadLine());

            double totalSecs = numberOfSteps * secsPerStep;

            var timeArrival = startTime.AddSeconds(totalSecs);

            Console.WriteLine($"Time Arrival: {timeArrival:HH:mm:ss}");
        }
    }
}
