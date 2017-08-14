using System;

namespace Drawing_Tool
{
    public class StartUp
    {
        public static void Main()
        {
            ReadQuadrangleData().Draw();
        }

        private static Quadrangle ReadQuadrangleData()
        {
            var quadrangleType = Console.ReadLine();
            var lenght = int.Parse(Console.ReadLine());

            if (quadrangleType.Equals("Square"))
            {
                Quadrangle square = new Square(lenght);
                return square;
            }
            else
            {
                var height = int.Parse(Console.ReadLine());
                Quadrangle rectangle = new Rectangle(lenght, height);
                return rectangle;
            }
        }
    }
}
