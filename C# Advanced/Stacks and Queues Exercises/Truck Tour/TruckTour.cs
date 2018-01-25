using System;
using System.Collections.Generic;
using System.Linq;

namespace Truck_Tour
{
    public class TruckTour
    {
        public static void Main()
        {
            var numberOfPumps = long.Parse(Console.ReadLine());

            var litresPerPump = new Queue<long>();
            var distancesToNextPupm = new Queue<long>();

            for (int i = 0; i < numberOfPumps; i++)
            {
                var litresDistances = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();

                litresPerPump.Enqueue(litresDistances[0]);
                distancesToNextPupm.Enqueue(litresDistances[1]);
            }

            var litres = litresPerPump.Peek();
            var distance = distancesToNextPupm.Peek();

            var canGoAround = false;

            for (int i = 0; i < numberOfPumps; i++)
            {
                var petrolLeft = 0L;

                for (int j = 0; j < numberOfPumps; j++)
                {

                    if (litres + petrolLeft >= distance)
                    {
                        petrolLeft = litres + petrolLeft - distance;

                        litresPerPump.Enqueue(litresPerPump.Dequeue());
                        litres = litresPerPump.Peek();
                        distancesToNextPupm.Enqueue(distancesToNextPupm.Dequeue());
                        distance = distancesToNextPupm.Peek();

                        canGoAround = true;
                    }
                    else
                    {
                        for (int k = 0; k < numberOfPumps + 1 - j; k++)
                        {
                            litresPerPump.Enqueue(litresPerPump.Dequeue());
                            litres = litresPerPump.Peek();
                            distancesToNextPupm.Enqueue(distancesToNextPupm.Dequeue());
                            distance = distancesToNextPupm.Peek();
                        }

                        canGoAround = false;
                        break;
                    }
                }

                if (canGoAround)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}
