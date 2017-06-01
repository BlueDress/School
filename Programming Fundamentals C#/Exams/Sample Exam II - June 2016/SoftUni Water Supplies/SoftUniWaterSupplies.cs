using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Water_Supplies
{
    public class SoftUniWaterSupplies
    {
        public static void Main()
        {
            var totalAmauntOfWater = double.Parse(Console.ReadLine());
            var bottles = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var bottleCapacity = int.Parse(Console.ReadLine());
            var waterIsEnough = true;

            if (totalAmauntOfWater % 2 == 0)
            {
                for (int i = 0; i < bottles.Length; i++)
                {
                    var amauntForOneBottle = bottleCapacity - bottles[i];

                    if (totalAmauntOfWater >= amauntForOneBottle)
                    {
                        totalAmauntOfWater -= amauntForOneBottle;
                    }
                    else
                    {
                        var indexes = new List<int>();
                        indexes.Add(i);
                        var bottlesLeft = 1;
                        var amountOfWaterNeeded = amauntForOneBottle - totalAmauntOfWater;

                        for (int j = i + 1; j < bottles.Length; j++)
                        {
                            if (bottleCapacity - bottles[j] > 0)
                            {
                                bottlesLeft++;
                                indexes.Add(j);
                                amountOfWaterNeeded += bottleCapacity - bottles[j];
                            }
                        }

                        Console.WriteLine("We need more water!");
                        Console.WriteLine($"Bottles left: {bottlesLeft}");
                        Console.WriteLine($"With indexes: {string.Join(", ", indexes)}");
                        Console.WriteLine($"We need {amountOfWaterNeeded} more liters!");

                        waterIsEnough = false;
                        break;
                    }
                }

                if (waterIsEnough)
                {
                    Console.WriteLine($"Enough water!");
                    Console.WriteLine($"Water left: {totalAmauntOfWater}l.");
                }
            }
            else
            {
                for (int i = bottles.Length - 1; i >= 0; i--)
                {
                    var amauntForOneBottle = bottleCapacity - bottles[i];

                    if (totalAmauntOfWater >= amauntForOneBottle)
                    {
                        totalAmauntOfWater -= amauntForOneBottle;
                    }
                    else
                    {
                        var indexes = new List<int>();
                        indexes.Add(i);
                        var bottlesLeft = 1;
                        var amountOfWaterNeeded = amauntForOneBottle - totalAmauntOfWater;

                        for (int j = i - 1; j >= 0; j--)
                        {
                            if (bottleCapacity - bottles[j] > 0)
                            {
                                bottlesLeft++;
                                indexes.Add(j);
                                amountOfWaterNeeded += bottleCapacity - bottles[j];
                            }
                        }

                        Console.WriteLine("We need more water!");
                        Console.WriteLine($"Bottles left: {bottlesLeft}");
                        Console.WriteLine($"With indexes: {string.Join(", ", indexes)}");
                        Console.WriteLine($"We need {amountOfWaterNeeded} more liters!");

                        waterIsEnough = false;
                        break;
                    }
                }

                if (waterIsEnough)
                {
                    Console.WriteLine($"Enough water!");
                    Console.WriteLine($"Water left: {totalAmauntOfWater}l.");
                }
            }
        }
    }
}
