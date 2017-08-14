﻿
using System;

namespace Shapes
{
    public class StartUp
    {
        public static void Main()
        {
            Rectangle rectangle = new Rectangle(3, 4);
            Circle circle = new Circle(5);

            Console.WriteLine(rectangle.CalculateArea());
            Console.WriteLine(rectangle.CalculatePerimeter());
            Console.WriteLine(rectangle.Draw());

            Console.WriteLine();

            Console.WriteLine(circle.CalculateArea());
            Console.WriteLine(circle.CalculatePerimeter());
            Console.WriteLine(circle.Draw());
        }
    }
}
