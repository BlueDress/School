using System;

namespace Odd_Number
{
    public class Startup
    {
        public static void Main()
        {
            while (true)
            {
                var number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    Console.WriteLine("Please write an odd number.");
                }
                else
                {
                    Console.WriteLine($"The number is: {Math.Abs(number)}");
                    break;
                }
            }
        }
    }
}
