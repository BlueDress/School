using System;

namespace Resurrection
{
    public class Startup
    {
        public static void Main()
        {
            var numberOfPhoenixes = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPhoenixes; i++)
            {
                var bodyLenght = long.Parse(Console.ReadLine());
                var bodyWidth = decimal.Parse(Console.ReadLine());
                var wingLenght = long.Parse(Console.ReadLine());

                var totalYears = (bodyLenght * bodyLenght) * (bodyWidth + (2 * wingLenght));

                Console.WriteLine(totalYears);
            }
        }
    }
}
