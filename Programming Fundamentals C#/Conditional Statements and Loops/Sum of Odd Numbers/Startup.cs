using System;

namespace Sum_of_Odd_Numbers
{
    public class Startup
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            var sum = 0;

            for (int i = 1; i < number * 2; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                    sum += i;
                }
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
