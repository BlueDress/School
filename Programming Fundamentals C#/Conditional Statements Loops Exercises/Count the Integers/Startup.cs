using System;

namespace Count_the_Integers
{
    public class Startup
    {
        public static void Main()
        {
            var numbersCount = 0;

            while (true)
            {
                var temp = 0;

                if (int.TryParse(Console.ReadLine(), out temp))
                {
                    numbersCount++;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(numbersCount);
        }
    }
}
