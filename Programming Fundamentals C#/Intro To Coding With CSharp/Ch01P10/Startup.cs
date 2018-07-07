using System;

namespace Ch01P10
{
    public class Startup
    {
        public static void Main()
        {
            for (int i = 2; i < 102; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(i * (-1));
                }
            }
        }
    }
}
