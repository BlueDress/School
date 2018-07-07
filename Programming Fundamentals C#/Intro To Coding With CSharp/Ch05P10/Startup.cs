using System;

namespace Ch05P10
{
    public class Startup
    {
        public static void Main()
        {
            int points = int.Parse(Console.ReadLine());

            if (1 <= points && points <= 3)
            {
                Console.WriteLine(points * 10);
            }
            else if (4 <= points && points <= 6)
            {
                Console.WriteLine(points * 100);
            }
            else if (7 <= points && points <= 9)
            {
                Console.WriteLine(points * 1000);
            }
            else
            {
                Console.WriteLine("Points must be number between 1 and 9 both inclusive");
            }
        }
    }
}
