using System;

namespace Shapes
{
    public class Circle : IDrawable
    {
        private int radius;

        public Circle(int radius)
        {
            this.radius = radius;
        }

        public void Draw()
        {
            var radiusIn = this.radius - 0.4;
            var radiusOut = this.radius + 0.4;

            for (int i = this.radius; i >= -this.radius; --i)
            {
                for (double j = -this.radius; j < radiusOut; j += 0.5)
                {
                    var value = i * i + j * j;
                    if (value >= radiusIn * radiusIn && value <= radiusOut * radiusOut)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
