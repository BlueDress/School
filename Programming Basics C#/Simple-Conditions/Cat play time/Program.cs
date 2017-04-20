using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat_play_time
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете брой на почивните дни на година ");
            var restdays = int.Parse(Console.ReadLine());

            var playtime = (restdays * 127) + ((365 - restdays) * 63);

            if (playtime > 30000)
            {
                var a = playtime - 30000;
                var h = a / 60;
                var m = a % 60;
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{h} hours and {m} minutes more for play");
            }
            else
            {
                var a = 30000 - playtime;
                var h = a / 60;
                var m = a % 60;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{h} hours and {m} minutes less for play");
            }
        }
    }
}
