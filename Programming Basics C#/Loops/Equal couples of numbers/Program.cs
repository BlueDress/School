using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_couples_of_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете брой двойки ");
            var n = int.Parse(Console.ReadLine());

            var checkmin = int.MaxValue;
            var checkmax = int.MinValue;
            var sum = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Въведете число ");
                var a = int.Parse(Console.ReadLine());

                Console.Write("Въведете число ");
                var b = int.Parse(Console.ReadLine());

                sum = a + b;
                if (sum > checkmax) checkmax = sum;
                if (sum < checkmin) checkmin = sum;
            }
            if (checkmax == checkmin)
                Console.WriteLine($"Yes, value={checkmax}");
            else
                Console.WriteLine($"No, maxdiff={checkmax - checkmin}");
        }
    }
}
