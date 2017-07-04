using System;

namespace Parking_System
{
    public class ParkingSystem
    {
        public static void Main()
        {
            var dimensions = Console.ReadLine().Split();
            var rows = int.Parse(dimensions[0]);
            var cols = int.Parse(dimensions[1]);

            var parkingLot = new string[rows][];

            for (int row = 0; row < parkingLot.Length; row++)
            {
                parkingLot[row] = new string[cols];

                for (int col = 0; col < parkingLot[row].Length; col++)
                {
                    parkingLot[row][col] = "empty";
                }
            }

            while (true)
            {
                var input = Console.ReadLine();

                if (input.Equals("stop"))
                {
                    break;
                }
                else
                {
                    var commands = input.Split();
                    var entryRow = int.Parse(commands[0]);
                    var desiredRow = int.Parse(commands[1]);
                    var desiredCol = int.Parse(commands[2]);

                    var distanceTravelled = 0;
                    var rowIsFull = true;

                    if (parkingLot[desiredRow][desiredCol].Equals("empty"))
                    {
                        distanceTravelled = Math.Abs(desiredRow - entryRow) + desiredCol + 1;
                        parkingLot[desiredRow][desiredCol] = "taken";
                        Console.WriteLine(distanceTravelled);
                    }
                    else
                    {
                        for (int col = 1; col < cols; col++)
                        {
                            if (parkingLot[desiredRow][col].Equals("empty"))
                            {
                                distanceTravelled = Math.Abs(desiredRow - entryRow) + col + 1;
                                parkingLot[desiredRow][col] = "taken";
                                Console.WriteLine(distanceTravelled);
                                rowIsFull = false;
                                break;
                            }
                        }

                        if (rowIsFull)
                        {
                            Console.WriteLine($"Row {desiredRow} full");
                        }
                    }
                }
            }
        }
    }
}
