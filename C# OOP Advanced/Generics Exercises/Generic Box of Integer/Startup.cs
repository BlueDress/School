using System;

namespace Generic_Box_of_Integer
{
    public class Startup
    {
        public static void Main()
        {
            var numberOfInts = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfInts; i++)
            {
                var newInt = int.Parse(Console.ReadLine());

                var intBox = new Box<int>(newInt);

                Console.WriteLine(intBox.ToString());
            }
        }
    }
}
