using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Method
{
    class Program
    {
        public static int GetMax(int first, int second)
        {
            return Math.Max(first, second);
        }
        static void Main(string[] args)
        {
            var first = int.Parse(Console.ReadLine());
            var second = int.Parse(Console.ReadLine());
            var third = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMax(GetMax(first, second), third));
        }
    }
}
