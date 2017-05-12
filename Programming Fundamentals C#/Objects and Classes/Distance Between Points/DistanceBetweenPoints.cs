using System;
using System.Linq;

namespace Distance_Between_Points
{
    public class DistanceBetweenPoints
    {
        public static double DistanceBetweenPointsMethod(Point point1, Point point2)
        {
            return Math.Sqrt(((point1.X - point2.X) * (point1.X - point2.X)) + ((point1.Y - point2.Y) * (point1.Y - point2.Y)));
        }
        public static void Main()
        {
            var firstPointInput = Console.ReadLine().Split().Select(int.Parse).ToList();
            var secondPointInput = Console.ReadLine().Split().Select(int.Parse).ToList();

            var firstPoint = new Point
            {
                X = firstPointInput[0],
                Y = firstPointInput[1]
            };
            var secondPoint = new Point
            {
                X = secondPointInput[0],
                Y = secondPointInput[1]
            };

            var distanceBetweenPoints = DistanceBetweenPointsMethod(firstPoint, secondPoint);
            Console.WriteLine($"{distanceBetweenPoints:F3}");
        }
    }
}
