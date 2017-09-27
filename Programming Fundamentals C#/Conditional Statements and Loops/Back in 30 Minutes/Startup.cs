using System;

namespace Back_in_30_Minutes
{
    public class Startup
    {
        public static void Main()
        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());

            var time = new DateTime(2017, 9, 25, hours, minutes, 0);

            time = time.AddMinutes(30);

            if (time.Minute > 9)
            {
                Console.WriteLine($"{time.Hour}:{time.Minute}");
            }
            else
            {
                Console.WriteLine($"{time.Hour}:0{time.Minute}");
            }
        }
    }
}
