using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Num_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете число ");
            var n = int.Parse(Console.ReadLine());
            var sum = 0;

            do
            {
                sum += n % 10;
                n /= 10;
            } while (n > 0);
            Console.WriteLine(sum);
        }
    }
}
