using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primes_in_Given_Range
{
    class Program
    {
        public static void PrimeCheck(int n)
        {
            var sum = 0;

            for (int num = 1; num <= Math.Sqrt(n); num++)
            {
                if (n % num == 0)
                {
                    sum++;
                }
            }
            if (sum == 1 && n > 1) Console.Write(n + ", ");
        }
        public static void FindPrimesInRange(int startNum, int endNum)
        {
            for (int i = startNum; i <= endNum; i++)
            {
                PrimeCheck(i);
            }
        }
        static void Main(string[] args)
        {
            var startNum = int.Parse(Console.ReadLine());
            var endNum = int.Parse(Console.ReadLine());

            FindPrimesInRange(startNum, endNum);
        }
    }
}
