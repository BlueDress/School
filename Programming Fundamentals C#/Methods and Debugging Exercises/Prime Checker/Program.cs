using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Checker
{
    class Program
    {
        public static bool PrimeCheck(long n)
        {
            var sum = 0;

            for (int num = 1; num <= Math.Sqrt(n); num++)
            {
                if (n % num == 0)
                {
                    sum++;
                }
            }
            if (sum == 1 && n > 1) return true;
            else return false;
        }
        static void Main(string[] args)
        {
            var number = long.Parse(Console.ReadLine());
            Console.WriteLine(PrimeCheck(number));
        }
    }
}
