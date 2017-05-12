using System;
using System.Collections.Generic;
using System.Linq;

namespace Closest_Two_Points
{
    public class ClosestTwoPoints
    {
        public static double DistanceBetweenPoints(Point point1, Point point2)
        {
            return Math.Sqrt(((point1.X - point2.X) * (point1.X - point2.X)) + ((point1.Y - point2.Y) * (point1.Y - point2.Y)));
        }

        public static void Main()
        {
            var numberOfPoints = int.Parse(Console.ReadLine());
            var listOfPoints = new List<Point>();

            for (int i = 0; i < numberOfPoints; i++)
            {
                var inputCoordinates = Console.ReadLine().Split().Select(int.Parse).ToArray();
                listOfPoints.Add(new Point
                {
                    X = inputCoordinates[0],
                    Y = inputCoordinates[1]
                });
            }

            double closestDistance = double.MaxValue;
            var firstPoint = new Point();
            var secondPoint = new Point();

            for (int i = 0; i < listOfPoints.Count - 1; i++)
            {
                for (int j = i + 1; j < listOfPoints.Count; j++)
                {
                    var currentDistance = DistanceBetweenPoints(listOfPoints[i], listOfPoints[j]);

                    if (closestDistance > currentDistance)
                    {
                        closestDistance = currentDistance;
                        firstPoint = listOfPoints[i];
                        secondPoint = listOfPoints[j];
                    }
                }
            }

            Console.WriteLine($"{closestDistance:f3}");
            Console.WriteLine($"({firstPoint.X}, {firstPoint.Y})");
            Console.WriteLine($"({secondPoint.X}, {secondPoint.Y})");
        }
    }
}
