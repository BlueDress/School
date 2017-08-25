using System;
using System.Linq;

namespace Froggy
{
    public class Startup
    {
        public static void Main()
        {
            Console.WriteLine(string.Join(", ", new Lake(Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray())));
        }
    }
}
