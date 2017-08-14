

using System;

namespace Drawing_Tool
{
    public class Rectangle : Quadrangle
    {
        private int length;
        private int height;

        public Rectangle(int length, int height)
        {
            this.length = length;
            this.height = height;
        }

        public override void Draw()
        {
            Console.WriteLine($"|{new string('-', this.length)}|");
            for (int i = 0; i < this.height - 2; i++)
            {
                Console.WriteLine($"|{new string(' ', this.length)}|");
            }
            Console.WriteLine($"|{new string('-', this.length)}|");
        }
    }
}
