using System;

namespace Charity_Marathon
{
    public class CharityMarathon
    {
        public static void Main()
        {
            var days = int.Parse(Console.ReadLine());
            var registeredRunners = int.Parse(Console.ReadLine());
            var numberOfLaps = int.Parse(Console.ReadLine());
            var trackLength = int.Parse(Console.ReadLine());
            var trackCapacity = int.Parse(Console.ReadLine());
            var moneyPerKm = double.Parse(Console.ReadLine());

            var participatingRunners = 0;

            if (trackCapacity * days >= registeredRunners)
            {
                participatingRunners = registeredRunners;
            }
            else
            {
                participatingRunners = trackCapacity * days;
            }

            double totalKm = participatingRunners * numberOfLaps * trackLength / 1000;
            var totalMoneyRaised = totalKm * moneyPerKm;

            Console.WriteLine($"Money raised: {totalMoneyRaised:f2}");
        }
    }
}
