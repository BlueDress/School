using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sign_of_Integer_Number
{
    class Program
    {
        public static void SignOfNumber(int n)
        {
            if (n > 0)  Console.WriteLine($"The number {n} is positive");
            else if (n < 0)  Console.WriteLine($"The number {n} is negative");
            else  Console.WriteLine($"The number 0 is zero");

        }
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            SignOfNumber(number);
        }
    }
}
