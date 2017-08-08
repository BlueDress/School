using System;
using System.Collections.Generic;
using System.Linq;

namespace Rectangle_Intersection
{
    public class RectangleIntersection
    {
        public static void Main()
        {
            var tokens = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var rectangles = new Dictionary<string, Rectangle>();

            ProcessRectaglesData(tokens, rectangles);
            IntersectionsCheck(tokens, rectangles);
        }

        private static void IntersectionsCheck(int[] tokens, Dictionary<string, Rectangle> rectangles)
        {
            var numberOfChecks = tokens[1];

            for (int i = 0; i < numberOfChecks; i++)
            {
                var rectanglesId = Console.ReadLine().Split();
                var firstRectangleId = rectanglesId[0];
                var secondRectangleId = rectanglesId[1];

                var firstRectangle = rectangles[firstRectangleId];
                var secondRectangle = rectangles[secondRectangleId];

                if (firstRectangle.IntersectionCheck(secondRectangle))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }

        private static void ProcessRectaglesData(int[] tokens, Dictionary<string, Rectangle> rectangles)
        {
            var numberOfRectangles = tokens[0];

            for (int i = 0; i < numberOfRectangles; i++)
            {
                var rectangleData = Console.ReadLine().Split();
                var id = rectangleData[0];
                var width = int.Parse(rectangleData[1]);
                var height = int.Parse(rectangleData[2]);
                var topLeftXAxis = int.Parse(rectangleData[3]);
                var topLeftYAxis = int.Parse(rectangleData[4]);

                var rectangle = new Rectangle(id, width, height, topLeftXAxis, topLeftYAxis);
                rectangles[id] = rectangle;
            }
        }
    }
}
