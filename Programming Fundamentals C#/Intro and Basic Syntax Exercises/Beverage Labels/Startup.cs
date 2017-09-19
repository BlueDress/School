using System;

namespace Beverage_Labels
{
    public class Startup
    {
        public static void Main()
        {
            var beverageName = Console.ReadLine();
            var beverageVolume = double.Parse(Console.ReadLine());
            var energyPerHundredMl = double.Parse(Console.ReadLine());
            var sugarPerHundredMl = double.Parse(Console.ReadLine());

            var totalBeverageEnergy = beverageVolume / 100 * energyPerHundredMl;
            var totalBeverageSugar = beverageVolume / 100 * sugarPerHundredMl;

            Console.WriteLine($"{beverageVolume}ml {beverageName}:");
            Console.WriteLine($"{totalBeverageEnergy}kcal, {totalBeverageSugar}g sugars");
        }
    }
}
