using System;

namespace Ferrari
{
    public class Startup
    {
        public static void Main()
        {
            var model = "488-Spider";
            var driverName = Console.ReadLine();

            ICar ferrari = new Ferrari(model, driverName);
            Console.WriteLine(ferrari.ToString()); 
        }
    }
}
