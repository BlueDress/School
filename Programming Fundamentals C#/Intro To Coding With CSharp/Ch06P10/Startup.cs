using System;

namespace Ch06P10
{
    public class Startup
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                for (int j = i; j < i + number; j++)
                {
                    Console.Write(j);
                }

                Console.WriteLine();
            }
        }
    }
}
