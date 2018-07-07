using System;

namespace Ch01P11
{
    public class Startup
    {
        public static void Main()
        {
            Console.Write("Enter your age:");
            int currentAge = int.Parse(Console.ReadLine());

            Console.WriteLine($"In ten years you will be {currentAge + 10} years old");
        }
    }
}
