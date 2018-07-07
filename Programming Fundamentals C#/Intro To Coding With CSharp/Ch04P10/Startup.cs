using System;

namespace Ch04P10
{
    public class Startup
    {
        public static void Main()
        {
            int numbersCount = int.Parse(Console.ReadLine());

            long sum = 0;

            for (int i = 0; i < numbersCount; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum += number;
            }

            Console.WriteLine(sum);
        }
    }
}
