using System;

namespace Rectangle_Area
{
    public class Startup
    {
        public static void Main()
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            var area = width * height;

            Console.WriteLine($"{area:f2}");
        }
    }
}
