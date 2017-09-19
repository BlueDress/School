using System;

namespace Greeting
{
    public class Startup
    {
        public static void Main()
        {
            var name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
