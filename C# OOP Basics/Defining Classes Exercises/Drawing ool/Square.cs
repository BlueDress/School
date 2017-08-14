using System;

namespace Drawing_Tool
{
    public class Square : Quadrangle
    {
        private int length;

        public Square(int length)
        {
            this.length = length;
        }

        public override void Draw()
        {
            Console.WriteLine($"|{new string('-', this.length)}|");
            for (int i = 0; i < this.length - 2; i++)
            {
                Console.WriteLine($"|{new string(' ', this.length)}|");
            }
            Console.WriteLine($"|{new string('-', this.length)}|");
        }
    }
}
