using System;

namespace Triangle_of_Numbers
{
    public class Startup
    {
        public static void Main()
        {
            var numberOfRows = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfRows; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
