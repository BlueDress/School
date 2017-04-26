using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greater_of_Two_Values
{
    class Program
    {
        public static int GetMax(int first, int second)
        {
            return Math.Max(first, second);
        }
        public static char GetMax(char first, char second)
        {
            if (first > second) return first;
            else return second;
        }
        public static string GetMax(string first, string second)
        {
            if (first.CompareTo(second) >= 0) return first;
            else return second;
        }
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            if (input == "int")
            {
                var first = int.Parse(Console.ReadLine());
                var second = int.Parse(Console.ReadLine());
                var max = GetMax(first, second);
                Console.WriteLine(max);
            }
            else if (input == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                char max = GetMax(first, second);
                Console.WriteLine(max);
            }
            else if (input == "string")
            {
                var first = Console.ReadLine();
                var second = Console.ReadLine();
                var max = GetMax(first, second);
                Console.WriteLine(max);
            }
        }
    }
}
