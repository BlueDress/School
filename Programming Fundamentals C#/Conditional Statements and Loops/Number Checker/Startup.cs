using System;

namespace Number_Checker
{
    public class Startup
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            try
            {
                var number = int.Parse(input);
                Console.WriteLine("It is a number.");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
