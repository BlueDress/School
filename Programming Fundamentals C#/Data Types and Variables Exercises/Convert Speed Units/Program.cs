using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            var distance = float.Parse(Console.ReadLine());
            var hours = float.Parse(Console.ReadLine());
            var mins = float.Parse(Console.ReadLine());
            var secs = float.Parse(Console.ReadLine());

            float ms = distance / ((hours * 3600) + (mins * 60) + secs);
            float kmh = (distance / 1000) / (hours + (mins / 60) + (secs / 3600));
             
            Console.WriteLine($"{ms}");
            Console.WriteLine($"{kmh}");
            Console.WriteLine($"{(float)(distance / 1609) / (hours + (mins / 60) + (secs / 3600))}");
        }
    }
}
