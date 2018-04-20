using System;

namespace ImplementFirstLastList
{
    public class Startup
    {
        public static void Main()
        {
            FirstLastList<int> list = new FirstLastList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);

            Console.WriteLine();
        }
    }
}
