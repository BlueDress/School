using System;

namespace Choose_a_Drink
{
    public class Startup
    {
        public static void Main()
        {
            var profession = Console.ReadLine();

            switch (profession)
            {
                case "Athlete":
                    Console.WriteLine("Water");
                    break;
                case "SoftUni Student":
                    Console.WriteLine("Beer");
                    break;
                case "Businessman":
                case "Businesswoman":
                    Console.WriteLine("Coffee");
                    break;
                default:
                    Console.WriteLine("Tea");
                    break;
            }
        }
    }
}
