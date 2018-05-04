using System;

namespace ImplementKdTree
{
    public class Startup
    {
        public static void Main()
        {
            KdTree tree = new KdTree();
            tree.Insert(new Point2D(5, 5));
            tree.Insert(new Point2D(3, 2));
            tree.Insert(new Point2D(2, 6));
            tree.Insert(new Point2D(8, 8));
            tree.Insert(new Point2D(8, 9));

            Console.WriteLine(tree.Contains(new Point2D(8, 8)));
            Console.WriteLine(tree.Contains(new Point2D(8, 9)));
            Console.WriteLine(tree.Contains(new Point2D(2, 6)));
            Console.WriteLine(tree.Contains(new Point2D(3, 2)));
            Console.WriteLine(tree.Contains(new Point2D(5, 5)));
            Console.WriteLine(tree.Contains(new Point2D(18, 8)));
            Console.WriteLine(tree.Contains(new Point2D(8, 19)));
            Console.WriteLine(tree.Contains(new Point2D(12, 16)));
            Console.WriteLine(tree.Contains(new Point2D(-3, -2)));
            Console.WriteLine(tree.Contains(new Point2D(555, -555)));
        }
    }
}
