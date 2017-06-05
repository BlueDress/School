using System;

namespace Sweet_Dessert
{
    public class SweetDessert
    {
        public static void Main()
        {
            var cashAvailable = float.Parse(Console.ReadLine());
            var guests = int.Parse(Console.ReadLine());
            var bananasPrice = float.Parse(Console.ReadLine());
            var eggsPrice = float.Parse(Console.ReadLine());
            var berriesPrice = float.Parse(Console.ReadLine());

            var setsOfPortions = 0;

            if (guests % 6 == 0)
            {
                setsOfPortions = guests / 6;
            }
            else
            {
                setsOfPortions = guests / 6 + 1;
            }

            var cashNeeded = (2 * bananasPrice + 4 * eggsPrice + 0.2 * berriesPrice) * setsOfPortions;

            if (cashAvailable >= cashNeeded)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {cashNeeded:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {cashNeeded - cashAvailable:f2}lv more.");
            }
        }
    }
}