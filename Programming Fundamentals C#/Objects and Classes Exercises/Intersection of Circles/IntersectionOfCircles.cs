using System;
using System.Linq;

namespace Intersection_of_Circles
{
    public class IntersectionOfCircles
    {
        public static double DistanceBetweenPoints(Point point1, Point point2)
        {
            return Math.Sqrt(((point1.X - point2.X) * (point1.X - point2.X)) + ((point1.Y - point2.Y) * (point1.Y - point2.Y)));
        }

        public static bool AreIntersecting(Circle firstCircle, Circle secondCircle)
        {
            if (DistanceBetweenPoints(firstCircle.Center, secondCircle.Center) < firstCircle.Radius + secondCircle.Radius)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void Main()
        {
            var inputFirstCircle = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var inputSecondCircle = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var firstCircle = new Circle
            {
                Radius = inputFirstCircle[2],
                Center = new Point
                {
                    X = inputFirstCircle[0],
                    Y = inputFirstCircle[1]
                }
            };
            var secondCircle = new Circle
            {
                Radius = inputSecondCircle[2],
                Center = new Point
                {
                    X = inputSecondCircle[0],
                    Y = inputSecondCircle[1]
                }
            };

            if (AreIntersecting(firstCircle, secondCircle) == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
