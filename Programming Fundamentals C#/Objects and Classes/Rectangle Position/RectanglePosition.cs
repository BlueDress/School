using System;
using System.Linq;

namespace Rectangle_Position
{
    public class RectanglePosition
    {
        public static void Main()
        {
            var inputFirstRectangle = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var inputSecondRectangle = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var firstRectangle = new Rectangle
            {
                Left = inputFirstRectangle[0],
                Top = inputFirstRectangle[1],
                Width = inputFirstRectangle[2],
                Height = inputFirstRectangle[3]
            };

            var secondRectangle = new Rectangle
            {
                Left = inputSecondRectangle[0],
                Top = inputSecondRectangle[1],
                Width = inputSecondRectangle[2],
                Height = inputSecondRectangle[3]
            };

            if (firstRectangle.Left >= secondRectangle.Left && firstRectangle.Top >= secondRectangle.Top && firstRectangle.Left + firstRectangle.Width <= secondRectangle.Left + secondRectangle.Width && firstRectangle.Top + firstRectangle.Height <= secondRectangle.Top + secondRectangle.Height)
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Outside");
            }
        }
    }
}
