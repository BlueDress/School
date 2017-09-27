using System;

namespace Choose_a_Drink_2._0
{
    public class Startup
    {
        public static void Main()
        {
            var profession = Console.ReadLine();
            var quantity = int.Parse(Console.ReadLine());

            switch (profession)
            {
                case "Athlete":
                    Console.WriteLine($"The {profession} has to pay {quantity * 0.7:f2}.");
                    break;
                case "SoftUni Student":
                    Console.WriteLine($"The {profession} has to pay {quantity * 1.7:f2}.");
                    break;
                case "Businessman":
                case "Businesswoman":
                    Console.WriteLine($"The {profession} has to pay {quantity:f2}.");
                    break;
                default:
                    Console.WriteLine($"The {profession} has to pay {quantity * 1.2:f2}.");
                    break;
            }
        }
    }
}
