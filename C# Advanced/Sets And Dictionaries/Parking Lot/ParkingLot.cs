using System;
using System.Collections.Generic;

namespace Parking_Lot
{
    public class ParkingLot
    {
        public static void Main()
        {
            var cars = new HashSet<string>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input.Equals("END"))
                {
                    break;
                }
                else
                {
                    var commands = input.Split(new[] {',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    var direction = commands[0];
                    var carNumber = commands[1];

                    if (direction.Equals("IN"))
                    {
                        cars.Add(carNumber);
                    }
                    else
                    {
                        if (cars.Contains(carNumber))
                        {
                            cars.Remove(carNumber);
                        }
                    }
                }
            }
            if (cars.Count > 0)
            {
                foreach (var carNumber in cars)
                {
                    Console.WriteLine(carNumber);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
