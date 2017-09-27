using System;

namespace Passed_or_Failed
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
            else
            {
                Console.WriteLine("Failed!");
            }
        }
    }
}
