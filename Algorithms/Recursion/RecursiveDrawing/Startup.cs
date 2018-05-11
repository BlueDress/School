using System;

namespace RecursiveDrawing
{
    public class Startup
    {
        public static void Main()
        {
            var numberOfLines = int.Parse(Console.ReadLine());

            DrawLines(numberOfLines);
        }

        private static void DrawLines(int numberOfLines)
        {
            if (numberOfLines == 0)
            {
                return;
            }

            Console.WriteLine(new string('*', numberOfLines));

            DrawLines(--numberOfLines);

            Console.WriteLine(new string('#', ++numberOfLines));
        }
    }
}
