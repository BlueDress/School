using System;

namespace Passed
{
    public class Startup
    {
        public static void Main()
        {
            var grade = double.Parse(Console.ReadLine());

            if (3.00 <= grade)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}
