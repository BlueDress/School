using System;

namespace Ch02P12
{
    public class Startup
    {
        public static void Main()
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            int employeeNumber = int.Parse(Console.ReadLine());
        }
    }
}
