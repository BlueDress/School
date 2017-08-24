using System;

namespace Generic_Box
{
    public class Startup
    {
        public static void Main()
        {
            var stringValue = Console.ReadLine();
            var stringBox = new Box<string>(stringValue);
            Console.WriteLine(stringBox.ToString());

            var intValue = int.Parse(Console.ReadLine());
            var intBox = new Box<int>(intValue);
            Console.WriteLine(intBox.ToString());
        }
    }
}
