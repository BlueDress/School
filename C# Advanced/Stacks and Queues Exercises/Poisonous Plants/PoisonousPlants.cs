using System;
using System.Collections.Generic;
using System.Linq;

namespace Poisonous_Plants
{
    public class PoisonousPlants
    {
        public static void Main()
        {
            var numberOfPlants = int.Parse(Console.ReadLine());
            var pesticides = Console.ReadLine().Split().Select(int.Parse).ToList();

            var plants = new Queue<int>(pesticides);
            var days = 0;

            while (true)
            {
                var plantsLeft = plants.Count;
                var firstPlantPesticides = plants.Dequeue();
                plants.Enqueue(firstPlantPesticides);

                for (int i = 0; i < plantsLeft - 1; i++)
                {
                    if (plants.Peek() > firstPlantPesticides)
                    {
                        firstPlantPesticides = plants.Dequeue();
                    }
                    else
                    {
                        firstPlantPesticides = plants.Dequeue();
                        plants.Enqueue(firstPlantPesticides);
                    }
                }

                if (plantsLeft != plants.Count)
                {
                    days++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(days);
        }
    }
}
