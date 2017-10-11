using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            var record = double.Parse(Console.ReadLine());
            var distance = double.Parse(Console.ReadLine());
            var secsForM = double.Parse(Console.ReadLine());

            var timeForSwim = distance * secsForM;
            var slowing = Math.Floor(distance / 15) * 12.5;

            var totalTime = timeForSwim + slowing;

            if (record > totalTime)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {totalTime - record:f2} seconds slower.");
            }
        }
    }
}
